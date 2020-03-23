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
    public class LandLordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LandLordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LandLords
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LandLord.Include(l => l.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LandLords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landLord = await _context.LandLord
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.AdminID == id);
            if (landLord == null)
            {
                return NotFound();
            }

            return View(landLord);
        }

        // GET: LandLords/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: LandLords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdminID,IdentityUserId,EmailAddress")] LandLord landLord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landLord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", landLord.IdentityUserId);
            return View(landLord);
        }

        // GET: LandLords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landLord = await _context.LandLord.FindAsync(id);
            if (landLord == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", landLord.IdentityUserId);
            return View(landLord);
        }

        // POST: LandLords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdminID,IdentityUserId,EmailAddress")] LandLord landLord)
        {
            if (id != landLord.AdminID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landLord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandLordExists(landLord.AdminID))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", landLord.IdentityUserId);
            return View(landLord);
        }

        // GET: LandLords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landLord = await _context.LandLord
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.AdminID == id);
            if (landLord == null)
            {
                return NotFound();
            }

            return View(landLord);
        }

        // POST: LandLords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landLord = await _context.LandLord.FindAsync(id);
            _context.LandLord.Remove(landLord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LandLordExists(int id)
        {
            return _context.LandLord.Any(e => e.AdminID == id);
        }
    }
}
