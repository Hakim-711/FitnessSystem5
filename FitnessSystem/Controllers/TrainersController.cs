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
    public class TrainersController : Controller
    {
        private readonly FitnesSystemContext _context;

        public TrainersController(FitnesSystemContext context)
        {
            _context = context;
        }

        // GET: Trainers
        public async Task<IActionResult> Index()
        {
              return _context.RegisterFormTrainer != null ? 
                          View(await _context.RegisterFormTrainer.ToListAsync()) :
                          Problem("Entity set 'FitnessSystemContext.RegisterFormTrainer'  is null.");
        }

        // GET: Trainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RegisterFormTrainer == null)
            {
                return NotFound();
            }

            var registerFormTrainer = await _context.RegisterFormTrainer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registerFormTrainer == null)
            {
                return NotFound();
            }

            return View(registerFormTrainer);
        }

        // GET: Trainers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,Experience,TrainerType")] RegisterFormTrainer registerFormTrainer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registerFormTrainer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registerFormTrainer);
        }

        // GET: Trainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RegisterFormTrainer == null)
            {
                return NotFound();
            }

            var registerFormTrainer = await _context.RegisterFormTrainer.FindAsync(id);
            if (registerFormTrainer == null)
            {
                return NotFound();
            }
            return View(registerFormTrainer);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,Experience,TrainerType")] RegisterFormTrainer registerFormTrainer)
        {
            if (id != registerFormTrainer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registerFormTrainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterFormTrainerExists(registerFormTrainer.Id))
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
            return View(registerFormTrainer);
        }

        // GET: Trainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RegisterFormTrainer == null)
            {
                return NotFound();
            }

            var registerFormTrainer = await _context.RegisterFormTrainer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registerFormTrainer == null)
            {
                return NotFound();
            }

            return View(registerFormTrainer);
        }

        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RegisterFormTrainer == null)
            {
                return Problem("Entity set 'FitnessSystemContext.RegisterFormTrainer'  is null.");
            }
            var registerFormTrainer = await _context.RegisterFormTrainer.FindAsync(id);
            if (registerFormTrainer != null)
            {
                _context.RegisterFormTrainer.Remove(registerFormTrainer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterFormTrainerExists(int id)
        {
          return (_context.RegisterFormTrainer?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
