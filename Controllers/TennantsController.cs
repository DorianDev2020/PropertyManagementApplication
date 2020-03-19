using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Property_Management.Data;
using Property_Management.Models;

namespace Property_Management.Controllers
{
    public class TennantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TennantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tennants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tennant.ToListAsync());
        }

        // GET: Tennants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennant = await _context.Tennant
                .FirstOrDefaultAsync(m => m.TennantID == id);
            if (tennant == null)
            {
                return NotFound();
            }

            return View(tennant);
        }

        // GET: Tennants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tennants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TennantID,Name,EmailAddress,Address,State,City")] Tennant tennant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tennant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tennant);
        }

        // GET: Tennants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennant = await _context.Tennant.FindAsync(id);
            if (tennant == null)
            {
                return NotFound();
            }
            return View(tennant);
        }

        // POST: Tennants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TennantID,Name,EmailAddress,Address,State,City")] Tennant tennant)
        {
            if (id != tennant.TennantID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tennant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TennantExists(tennant.TennantID))
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
            return View(tennant);
        }

        // GET: Tennants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennant = await _context.Tennant
                .FirstOrDefaultAsync(m => m.TennantID == id);
            if (tennant == null)
            {
                return NotFound();
            }

            return View(tennant);
        }

        // POST: Tennants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tennant = await _context.Tennant.FindAsync(id);
            _context.Tennant.Remove(tennant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TennantExists(int id)
        {
            return _context.Tennant.Any(e => e.TennantID == id);
        }
    }
}
