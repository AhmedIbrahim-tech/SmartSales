#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartSales.Data;
using SmartSales.Models;

namespace SmartSales.Controllers
{
    public class CampaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Campanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campany.ToListAsync());
        }

        // GET: Campanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campany = await _context.Campany
                .FirstOrDefaultAsync(m => m.Campany_Id == id);
            if (campany == null)
            {
                return NotFound();
            }

            return View(campany);
        }

        // GET: Campanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Campany_Id,Campany_Name,Campany_Owner,Campany_Phone,Campany_Address,Campany_Date,Campany_Description")] Campany campany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campany);
        }

        // GET: Campanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campany = await _context.Campany.FindAsync(id);
            if (campany == null)
            {
                return NotFound();
            }
            return View(campany);
        }

        // POST: Campanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Campany_Id,Campany_Name,Campany_Owner,Campany_Phone,Campany_Address,Campany_Date,Campany_Description")] Campany campany)
        {
            if (id != campany.Campany_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampanyExists(campany.Campany_Id))
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
            return View(campany);
        }

        // GET: Campanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campany = await _context.Campany
                .FirstOrDefaultAsync(m => m.Campany_Id == id);
            if (campany == null)
            {
                return NotFound();
            }

            return View(campany);
        }

        // POST: Campanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campany = await _context.Campany.FindAsync(id);
            _context.Campany.Remove(campany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampanyExists(int id)
        {
            return _context.Campany.Any(e => e.Campany_Id == id);
        }
    }
}
