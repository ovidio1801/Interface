using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RRHH.Data;
using RRHH.Models;

namespace RRHH.Controllers
{
    [Authorize(Policy = "CubitosAdmin")]
    public class TIPO_CHEQUEController : Controller
    {
        private readonly RRHHContext _context;

        public TIPO_CHEQUEController(RRHHContext context)
        {
            _context = context;
        }

        // GET: TIPO_CHEQUE
        public async Task<IActionResult> Index()
        {
            return View(await _context.TIPO_CHEQUE.ToListAsync());
        }

        // GET: TIPO_CHEQUE/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tIPO_CHEQUE = await _context.TIPO_CHEQUE
                .FirstOrDefaultAsync(m => m.ID_TIPO_CHEQUE == id);
            if (tIPO_CHEQUE == null)
            {
                return NotFound();
            }

            return View(tIPO_CHEQUE);
        }

        // GET: TIPO_CHEQUE/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TIPO_CHEQUE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_TIPO_CHEQUE,COD_TIPO_CHEQUE,DESCRIPCION")] TIPO_CHEQUE tIPO_CHEQUE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tIPO_CHEQUE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tIPO_CHEQUE);
        }

        // GET: TIPO_CHEQUE/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tIPO_CHEQUE = await _context.TIPO_CHEQUE.FindAsync(id);
            if (tIPO_CHEQUE == null)
            {
                return NotFound();
            }
            return View(tIPO_CHEQUE);
        }

        // POST: TIPO_CHEQUE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_TIPO_CHEQUE,COD_TIPO_CHEQUE,DESCRIPCION")] TIPO_CHEQUE tIPO_CHEQUE)
        {
            if (id != tIPO_CHEQUE.ID_TIPO_CHEQUE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tIPO_CHEQUE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TIPO_CHEQUEExists(tIPO_CHEQUE.ID_TIPO_CHEQUE))
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
            return View(tIPO_CHEQUE);
        }

        // GET: TIPO_CHEQUE/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tIPO_CHEQUE = await _context.TIPO_CHEQUE
                .FirstOrDefaultAsync(m => m.ID_TIPO_CHEQUE == id);
            if (tIPO_CHEQUE == null)
            {
                return NotFound();
            }

            return View(tIPO_CHEQUE);
        }

        // POST: TIPO_CHEQUE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tIPO_CHEQUE = await _context.TIPO_CHEQUE.FindAsync(id);
            _context.TIPO_CHEQUE.Remove(tIPO_CHEQUE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TIPO_CHEQUEExists(int id)
        {
            return _context.TIPO_CHEQUE.Any(e => e.ID_TIPO_CHEQUE == id);
        }
    }
}
