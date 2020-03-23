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
    public class ListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Property_Listing.Include(l => l.LandLord).Include(l => l.Tennant);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Listings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Property_Listing
                .Include(l => l.LandLord)
                .Include(l => l.Tennant)
                .FirstOrDefaultAsync(m => m.ListingID == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // GET: Listings/Create
        public IActionResult Create()
        {
            ViewData["LandLordId"] = new SelectList(_context.LandLord, "AdminID", "AdminID");
            ViewData["TennantID"] = new SelectList(_context.Tennant, "TennantID", "TennantID");
            return View();
        }   

        // POST: Listings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListingID,Address,City,State,ZipCode,Available,SquareFeet,Beds,Baths,LandLordId,AdminID,TennantID")] Listing listing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LandLordId"] = new SelectList(_context.LandLord, "AdminID", "AdminID", listing.LandLordId);
            ViewData["TennantID"] = new SelectList(_context.Tennant, "TennantID", "TennantID", listing.TennantID);
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Property_Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            ViewData["LandLordId"] = new SelectList(_context.LandLord, "AdminID", "AdminID", listing.LandLordId);
            ViewData["TennantID"] = new SelectList(_context.Tennant, "TennantID", "TennantID", listing.TennantID);
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListingID,Address,City,State,ZipCode,Available,SquareFeet,Beds,Baths,LandLordId,AdminID,TennantID")] Listing listing)
        {
            if (id != listing.ListingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingID))
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
            ViewData["LandLordId"] = new SelectList(_context.LandLord, "AdminID", "AdminID", listing.LandLordId);
            ViewData["TennantID"] = new SelectList(_context.Tennant, "TennantID", "TennantID", listing.TennantID);
            return View(listing);
        }

        // GET: Listings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Property_Listing
                .Include(l => l.LandLord)
                .Include(l => l.Tennant)
                .FirstOrDefaultAsync(m => m.ListingID == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // POST: Listings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listing = await _context.Property_Listing.FindAsync(id);
            _context.Property_Listing.Remove(listing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListingExists(int id)
        {
            return _context.Property_Listing.Any(e => e.ListingID == id);
        }
    }
}
