using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using SpotMusic.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SpotMusic.Areas.Identity.Data;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http.Headers;
using Domain.Interfaces.Repositories;
using SpotMusic.Models;

namespace SpotMusic.Controllers
{
    [Authorize]
    public class MusicoController : Controller
    {
        private readonly IMusicoRepository _musicoRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public MusicoController(IMusicoRepository musicoRepository,
                                 UserManager<User> userManager,
                                 SignInManager<User> signInManager)
        {
            _musicoRepository = musicoRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Musico
        public async Task<IActionResult> Index(MusicoIndexViewModel musicoIndexRequest)
        {
            var userId = _userManager.GetUserId(User);

            var MusicoIndexViewModel = new MusicoIndexViewModel
            {
                Musicos = await _musicoRepository.GetAllAsync(userId)
            };
            return View(MusicoIndexViewModel);

            //return View(await _context.MusicoModel.ToListAsync());
        }

        // GET: Musico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicoModel = await _musicoRepository.GetByIdAsync(id.Value);

            if (musicoModel == null)
            {
                return NotFound();
            }

            return View(musicoModel);
        }

        // GET: Musico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( MusicoModel musicoModel,
                                                IFormCollection form,
                                                [FromServices] IHttpClientFactory clientFactory)
        {
            if (ModelState.IsValid)
            {
                using var content = new MultipartFormDataContent();

                foreach (var file in form.Files) /* reponsavel por receber os arquivos */
                {
                    content.Add(CreateFileContent(file.OpenReadStream(), file.FileName, file.ContentType));
                }

                var httpClient = clientFactory.CreateClient("");              /* reponsavel por enviar o ping para API */
                var response = await httpClient.PostAsync("api/Image", content);

                response.EnsureSuccessStatusCode(); /* garantir que o retorno será de familia 200 */

                var responseResult = await response.Content.ReadAsStringAsync();
                var uriImagem = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();



                var userId = _userManager.GetUserId(User);
                musicoModel.UserId = userId;
                musicoModel.ImageUri = uriImagem;

                await _musicoRepository.CreateAsync(musicoModel);

                return RedirectToAction(nameof(Index));
            }
            return View(musicoModel);
        }

        private StreamContent CreateFileContent(Stream stream, string fileName, string contentType)
        {   
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"files\"",
                FileName = "\"" + fileName + "\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return fileContent;
        }

        // GET: Musico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicoModel = await _musicoRepository.GetByIdAsync(id.Value);

            if (musicoModel == null)
            {
                return NotFound();
            }
            return View(musicoModel);
        }

        // POST: Musico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MusicoModel musicoModel,
                                                IFormCollection form,
                                                [FromServices] IHttpClientFactory clientFactory)
        {
            if (id != musicoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    using var content = new MultipartFormDataContent();

                    var files = form.Files.SingleOrDefault();
                    var streamFile = files?.OpenReadStream();

                    if (streamFile != null)
                    {
                        foreach (var file in form.Files)
                        {
                            content.Add(CreateFileContent(file.OpenReadStream(), file.FileName, file.ContentType));
                        }

                        var httpClient = clientFactory.CreateClient("");

                        var response = await httpClient.PostAsync("api/Image", content);

                        response.EnsureSuccessStatusCode();

                        var responseResult = await response.Content.ReadAsStringAsync();
                        var uriImagem = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();
                        musicoModel.ImageUri = uriImagem;
                    }

                    await _musicoRepository.EditAsync(musicoModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicoModelExists(musicoModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(musicoModel);
        }

        // GET: Musico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicoModel = await _musicoRepository.GetByIdAsync(id.Value);

            if (musicoModel == null)
            {
                return NotFound();
            }

            return View(musicoModel);
        }

        // POST: Musico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musico = _musicoRepository.GetByIdAsync(id).Result;

            await _musicoRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MusicoModelExists(int id)
        {
            var musico = _musicoRepository.GetByIdAsync(id).Result;

            return (musico != null);
        }
    }
}
