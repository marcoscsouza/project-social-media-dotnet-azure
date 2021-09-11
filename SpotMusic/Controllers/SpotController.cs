using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using SpotMusic.Data;
using Microsoft.AspNetCore.Identity;
using SpotMusic.Areas.Identity.Data;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace SpotMusic.Controllers
{
    [Authorize]
    public class SpotController : Controller
    {
        private readonly ISpotRepository _spotRepository;
        private readonly IMusicoRepository _musicoRepository;
        private readonly UserManager<User> _userManager;

        public SpotController(ISpotRepository spotRepository,
                              IMusicoRepository musicoRepository,
                              UserManager<User> userManager)
        {
            _spotRepository = spotRepository;
            _musicoRepository = musicoRepository;
            _userManager = userManager;
        }

        // GET: Spot
        public async Task<IActionResult> Index()
        {
            return View(await _spotRepository.GetAllAsync());
            //return View(await _context.Spots.ToListAsync());
        }

        // GET: Spot/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotModel = await _spotRepository.GetByIdAsync(id.Value);

            if (spotModel == null)
            {
                return NotFound();
            }

            return View(spotModel);
        }

        // GET: Spot/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spot/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpotModel spotModel)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);

                var musico = await _musicoRepository.GetProfileByUserIdAsync(userId);


                //var musico = await _context.Musicos.Where(x => x.UserId == userId).FirstOrDefaultAsync();

                spotModel.MusicoModel = musico;
                spotModel.DataCriacao = DateTime.Now;


                await _spotRepository.CreateAsync(spotModel);
                return RedirectToAction(nameof(Index));
            }
            return View(spotModel);
        }

        // GET: Spot/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotModel = await _spotRepository.GetByIdAsync(id.Value);

            if (spotModel == null)
            {
                return NotFound();
            }
            return View(spotModel);
        }

        // POST: Spot/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SpotModel spotModel)
        {
            if (id != spotModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _spotRepository.EditAsync(spotModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpotModelExists(spotModel.Id))
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
            return View(spotModel);
        }

        // GET: Spot/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotModel = await _spotRepository.GetByIdAsync(id.Value);

            if (spotModel == null)
            {
                return NotFound();
            }

            return View(spotModel);
        }

        // POST: Spot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spotModel = _spotRepository.GetByIdAsync(id).Result;

            await _spotRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool SpotModelExists(int id)
        {
            var spot = _spotRepository.GetByIdAsync(id).Result;

            return (spot != null);
        }
    }
}
