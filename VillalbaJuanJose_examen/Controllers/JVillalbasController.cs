using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VillalbaJuanJose_examen.Models;

namespace VillalbaJuanJose_examen.Controllers
{
    public class JVillalbasController : Controller
    {
        private readonly JVillalbacontext _context;

        public JVillalbasController(JVillalbacontext context)
        {
            _context = context;
        }

        // GET: JVillalbas
        public async Task<IActionResult> Index()
        {
            return View(await _context.JVillalba.ToListAsync());
        }

        // GET: JVillalbas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jVillalba = await _context.JVillalba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jVillalba == null)
            {
                return NotFound();
            }

            return View(jVillalba);
        }

        // GET: JVillalbas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JVillalbas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,peso,genero,fecha")] JVillalba jVillalba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jVillalba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jVillalba);
        }

        // GET: JVillalbas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jVillalba = await _context.JVillalba.FindAsync(id);
            if (jVillalba == null)
            {
                return NotFound();
            }
            return View(jVillalba);
        }

        // POST: JVillalbas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,peso,genero,fecha")] JVillalba jVillalba)
        {
            if (id != jVillalba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jVillalba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JVillalbaExists(jVillalba.Id))
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
            return View(jVillalba);
        }

        // GET: JVillalbas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jVillalba = await _context.JVillalba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jVillalba == null)
            {
                return NotFound();
            }

            return View(jVillalba);
        }

        // POST: JVillalbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jVillalba = await _context.JVillalba.FindAsync(id);
            if (jVillalba != null)
            {
                _context.JVillalba.Remove(jVillalba);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JVillalbaExists(int id)
        {
            return _context.JVillalba.Any(e => e.Id == id);
        }
    }
}
