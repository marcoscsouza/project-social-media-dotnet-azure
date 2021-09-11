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

namespace SpotMusic.Controllers
{
    [Authorize]
    public class MusicoController : Controller
    {
        private readonly SpotMusicContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public MusicoController(SpotMusicContext context,
                                 UserManager<User> userManager,
                                 SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Musico
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            var musico = await _context.Musicos.Where(x => x.UserId == userId).ToListAsync();

            return View(musico);

            //return View(await _context.MusicoModel.ToListAsync());
        }

        // GET: Musico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicoModel = await _context.Musicos
                .FirstOrDefaultAsync(m => m.Id == id);
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
        public async Task<IActionResult> Create( MusicoModel musicoModel)
        {
            if (ModelState.IsValid)
            {


                var userId = _userManager.GetUserId(User);
                musicoModel.UserId = userId;

                _context.Add(musicoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicoModel);
        }

        // GET: Musico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicoModel = await _context.Musicos.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, MusicoModel musicoModel)
        {
            if (id != musicoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicoModel);
                    await _context.SaveChangesAsync();
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

            var musicoModel = await _context.Musicos
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var musicoModel = await _context.Musicos.FindAsync(id);
            _context.Musicos.Remove(musicoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicoModelExists(int id)
        {
            return _context.Musicos.Any(e => e.Id == id);
        }
    }
}
