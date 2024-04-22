using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenP1_DRueda.Data;

namespace ExamenP1_DRueda.Controllers
{
    public class DRuedasController : Controller
    {
        private readonly ExamenP1_DRuedaContext _context;

        public DRuedasController(ExamenP1_DRuedaContext context)
        {
            _context = context;
        }

        // GET: DRuedas
        public async Task<IActionResult> Index()
        {
            return View(await _context.DRueda.ToListAsync());
        }

        // GET: DRuedas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dRueda = await _context.DRueda
                .FirstOrDefaultAsync(m => m.id == id);
            if (dRueda == null)
            {
                return NotFound();
            }

            return View(dRueda);
        }

        // GET: DRuedas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DRuedas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Nombre,pagoMatricula,IsMatriculado,Fecha")] DRueda dRueda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dRueda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dRueda);
        }

        // GET: DRuedas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dRueda = await _context.DRueda.FindAsync(id);
            if (dRueda == null)
            {
                return NotFound();
            }
            return View(dRueda);
        }

        // POST: DRuedas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Nombre,pagoMatricula,IsMatriculado,Fecha")] DRueda dRueda)
        {
            if (id != dRueda.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dRueda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DRuedaExists(dRueda.id))
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
            return View(dRueda);
        }

        // GET: DRuedas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dRueda = await _context.DRueda
                .FirstOrDefaultAsync(m => m.id == id);
            if (dRueda == null)
            {
                return NotFound();
            }

            return View(dRueda);
        }

        // POST: DRuedas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dRueda = await _context.DRueda.FindAsync(id);
            if (dRueda != null)
            {
                _context.DRueda.Remove(dRueda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DRuedaExists(int id)
        {
            return _context.DRueda.Any(e => e.id == id);
        }
    }
}
