using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodingClubTest.Models;

namespace CodingClubTest.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly CodingClubDbContext _context;

        public OrganizationsController(CodingClubDbContext context)
        {
            _context = context;
        }

        // Get: Organizations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Organization.ToListAsync());
        }

        //GET: Organization/Details
        public async Task<IActionResult> Details(string id)
        {
            if(id == null)
            {
                return NotFound();

            }
            var organization = await _context.Organization  
                .FirstOrDefaultAsync(m => m.ID ==id);
                if (organization == null)
                {
                    return NotFound(); 
                }
            return View(organization);
        }

        //GET Organization/Create
        public IActionResult Create()
        {
            return View();
        }
        

        //POST: Organization/Create
        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Create([Bind("ID,Email")] Organization organization)
        {
            if(ModelState.IsValid)
            {
                _context.Add(organization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(organization);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organization.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }
            return View(organization);
        }

        // POST: Organizations/Edit/5
     
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Email")] Organization organization)
        {
            if (id != organization.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizationExists(organization.ID))
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
            return View(organization);
        }

        // GET: Organizations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organization
                .FirstOrDefaultAsync(m => m.ID == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // POST: Organizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var organization = await _context.Organization.FindAsync(id);
            _context.Organization.Remove(organization);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizationExists(string id)
        {
            return _context.Organization.Any(e => e.ID == id);
        }
        
    }
}