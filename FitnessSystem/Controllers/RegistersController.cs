using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessSystem.Models;
using FitnessSystem.Data;

namespace FitnessSystem.Controllers
{
    public class RegistersController : Controller
    {
        private readonly FitnesSystemContext _context;

        public RegistersController(FitnesSystemContext context)
        {
            _context = context;
        }

        // GET: Registers
        public async Task<IActionResult> Index()
        {
            var fitnessSystemContext = _context.Register.Include(r => r.CountryNavigation).Include(r => r.Gender).Include(r => r.PlanNavigation);
            return View(await fitnessSystemContext.ToListAsync());
        }

        // GET: Registers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Register == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .Include(r => r.CountryNavigation)
                .Include(r => r.Gender)
                .Include(r => r.PlanNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // GET: Registers/Create
        public IActionResult Create()
        {
            ViewData["Country"] = new SelectList(_context.Set<LK_countries>(), "countru_id", "country_name");
            ViewData["GenderID"] = new SelectList(_context.Set<LK_Gender>(), "Id", "description");
            ViewData["Plan"] = new SelectList(_context.Set<LK_Plan>(), "Id", "name_plan");
            return View();
        }

        // POST: Registers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,GenderID,CurrentWeight,DesiredWeight,Height,BMI,HomeAddress,City,Code,Country,Email,Phone,Plan,Agree")] Register register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Country"] = new SelectList(_context.Set<LK_countries>(), "countru_id", "country_name", register.Country);
            ViewData["GenderID"] = new SelectList(_context.Set<LK_Gender>(), "Id", "description", register.GenderID);
            ViewData["Plan"] = new SelectList(_context.Set<LK_Plan>(), "Id", "name_plan", register.Plan);
            return View(register);
        }

        // GET: Registers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Register == null)
            {
                return NotFound();
            }

            var register = await _context.Register.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }
            ViewData["Country"] = new SelectList(_context.Set<LK_countries>(), "countru_id", "country_name", register.Country);
            ViewData["GenderID"] = new SelectList(_context.Set<LK_Gender>(), "Id", "description", register.GenderID);
            ViewData["Plan"] = new SelectList(_context.Set<LK_Plan>(), "Id", "name_plan", register.Plan);
            return View(register);
        }

        // POST: Registers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,GenderID,CurrentWeight,DesiredWeight,Height,BMI,HomeAddress,City,Code,Country,Email,Phone,Plan,Agree")] Register register)
        {
            if (id != register.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(register);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterExists(register.Id))
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
            ViewData["Country"] = new SelectList(_context.Set<LK_countries>(), "countru_id", "country_name", register.Country);
            ViewData["GenderID"] = new SelectList(_context.Set<LK_Gender>(), "Id", "description", register.GenderID);
            ViewData["Plan"] = new SelectList(_context.Set<LK_Plan>(), "Id", "name_plan", register.Plan);
            return View(register);
        }

        // GET: Registers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Register == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .Include(r => r.CountryNavigation)
                .Include(r => r.Gender)
                .Include(r => r.PlanNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // POST: Registers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Register == null)
            {
                return Problem("Entity set 'FitnessSystemContext.Register'  is null.");
            }
            var register = await _context.Register.FindAsync(id);
            if (register != null)
            {
                _context.Register.Remove(register);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterExists(int id)
        {
          return (_context.Register?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
