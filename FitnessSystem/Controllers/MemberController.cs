using FitnessSystem.Data;
using FitnessSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessSystem.Controllers
{
    public class MemberController : Controller
    {
        private readonly FitnesSystemContext _context;
public MemberController(FitnesSystemContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterFormTrainer()
        {
            try
            {
                var genders = _context.LK_Gender.ToList();
                if (genders == null || !genders.Any())
                {
                    // Log error or return an error message because there is no data
                    // to return. This is just a placeholder, replace it with your
                    // own error handling logic.
                    return Content("No genders found.");
                }
                ViewBag.TrainerTypes = _context.LK_trainerType.ToList();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel());

            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterFormTrainer(RegisterFormTrainer trainer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainer);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewBag.TrainerTypes = await _context.LK_trainerType.ToListAsync();
           
            return View(trainer);
        }

        public IActionResult Register()
        {
            try
            {
                var genders = _context.LK_Gender.ToList();
                if (genders == null || !genders.Any())
                {
                    // Log error or return an error message because there is no data
                    // to return. This is just a placeholder, replace it with your
                    // own error handling logic.
                    return Content("No genders found.");
                }
               ViewBag.TrainerTypes=_context.LK_trainerType.ToList();
                ViewBag.Genders = genders;
                ViewBag.Countries = _context.LK_countries.ToList();
                ViewBag.Plans = _context.LK_Plan.ToList();

                return View();
            }
            catch(Exception ex) 
            {
                return View("Error",new ErrorViewModel());
            }

            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Genders = await _context.LK_Gender.ToListAsync();
            ViewBag.Countries = await _context.LK_countries.ToListAsync();
            ViewBag.Plans = await _context.LK_Plan.ToListAsync();

            return View(register);
        }

        public IActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                // Process feedback submission, e.g., save to database, send email, etc.
                // ...

                return RedirectToAction("Success");
            }
            else
            {
                return View("Feedback", feedback);
            }
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Memebership()
        {
            return View();
        }
    }
}
