using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using SpotMusic.Data;

namespace SpotMusic.Controllers
{
    public class SpotController : Controller
    {
        private readonly SpotMusicContext _context;

        public SpotController(SpotMusicContext context)
        {
            _context = context;
        }

        // GET: Spot
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spots.ToListAsync());
        }

        // GET: Spot/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotModel = await _context.Spots
                .FirstOrDefaultAsync(m => m.Id == id);
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
        public async Task<IActionResult> Create([Bind("Id,Texto,DataCriacao")] SpotModel spotModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spotModel);
                await _context.SaveChangesAsync();
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

            var spotModel = await _context.Spots.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Texto,DataCriacao")] SpotModel spotModel)
        {
            if (id != spotModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spotModel);
                    await _context.SaveChangesAsync();
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

            var spotModel = await _context.Spots
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var spotModel = await _context.Spots.FindAsync(id);
            _context.Spots.Remove(spotModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpotModelExists(int id)
        {
            return _context.Spots.Any(e => e.Id == id);
        }
    }
}
