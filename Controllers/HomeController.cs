using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using student_registration.Data;
using student_registration.Models;
using System.Diagnostics;

namespace student_registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.message = "Student Fetched";
            ViewData["test"] = "ViewData test";
            var students = await _context.Students.Include(s=>s.Technology).ToListAsync();

            return View(students);
        }

        public  IActionResult Create()
        {
            ViewData["Locations"] = new SelectList(_context.Locations, "Id" , "Name");

            var test = ViewData["Locations"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {

            if (ModelState.IsValid)
            {

                _context.Students.Add(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View();
        }



        public async Task<IActionResult> Edit(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {

                _context.Students.Update(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(student);

        }



        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);

            return View(student);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);

            if(student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
