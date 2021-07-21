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
    public class ParametrosController : Controller
    {
        private readonly RRHHContext _context;

        public ParametrosController(RRHHContext context)
        {
            _context = context;
        }

        // GET: Parametro
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parametros.ToListAsync());
        }

        // GET: Parametro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.Parametros
                .FirstOrDefaultAsync(m => m.ID_PARAM == id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }

            return View(pS_CA_PARAM);
        }

        // GET: Parametro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parametro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_PARAM,CODIGO_TR,CENTRO,CUENTA_DB,CUENTA_CR,DESCRIPCION")] Parametro pS_CA_PARAM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pS_CA_PARAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pS_CA_PARAM);
        }

        // GET: Parametro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.Parametros.FindAsync(id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }
            return View(pS_CA_PARAM);
        }

        // POST: Parametro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_PARAM,CODIGO_TR,CENTRO,CUENTA_DB,CUENTA_CR,DESCRIPCION")] Parametro pS_CA_PARAM)
        {
            if (id != pS_CA_PARAM.ID_PARAM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pS_CA_PARAM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PS_CA_PARAMExists(pS_CA_PARAM.ID_PARAM))
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
            return View(pS_CA_PARAM);
        }

        // GET: Parametro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.Parametros
                .FirstOrDefaultAsync(m => m.ID_PARAM == id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }

            return View(pS_CA_PARAM);
        }

        // POST: Parametro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pS_CA_PARAM = await _context.Parametros.FindAsync(id);
            _context.Parametros.Remove(pS_CA_PARAM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PS_CA_PARAMExists(int id)
        {
            return _context.Parametros.Any(e => e.ID_PARAM == id);
        }
    }
}
