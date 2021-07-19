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
    public class PS_CA_PARAMController : Controller
    {
        private readonly RRHHContext _context;

        public PS_CA_PARAMController(RRHHContext context)
        {
            _context = context;
        }

        // GET: PS_CA_PARAM
        public async Task<IActionResult> Index()
        {
            return View(await _context.PS_CA_PARAM.ToListAsync());
        }

        // GET: PS_CA_PARAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.PS_CA_PARAM
                .FirstOrDefaultAsync(m => m.ID_PARAM == id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }

            return View(pS_CA_PARAM);
        }

        // GET: PS_CA_PARAM/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PS_CA_PARAM/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_PARAM,CODIGO_TR,CENTRO,CUENTA_DB,CUENTA_CR,DESCRIPCION")] PS_CA_PARAM pS_CA_PARAM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pS_CA_PARAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pS_CA_PARAM);
        }

        // GET: PS_CA_PARAM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.PS_CA_PARAM.FindAsync(id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }
            return View(pS_CA_PARAM);
        }

        // POST: PS_CA_PARAM/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_PARAM,CODIGO_TR,CENTRO,CUENTA_DB,CUENTA_CR,DESCRIPCION")] PS_CA_PARAM pS_CA_PARAM)
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

        // GET: PS_CA_PARAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pS_CA_PARAM = await _context.PS_CA_PARAM
                .FirstOrDefaultAsync(m => m.ID_PARAM == id);
            if (pS_CA_PARAM == null)
            {
                return NotFound();
            }

            return View(pS_CA_PARAM);
        }

        // POST: PS_CA_PARAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pS_CA_PARAM = await _context.PS_CA_PARAM.FindAsync(id);
            _context.PS_CA_PARAM.Remove(pS_CA_PARAM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PS_CA_PARAMExists(int id)
        {
            return _context.PS_CA_PARAM.Any(e => e.ID_PARAM == id);
        }
    }
}
