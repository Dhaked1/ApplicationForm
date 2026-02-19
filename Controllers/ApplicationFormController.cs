using Microsoft.AspNetCore.Mvc;
using ApplicationFormApp.Models;

namespace ApplicationFormApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApplicationFormController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Show Form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Submit Form
        [HttpPost]
        public IActionResult Create(ApplicationForm model)
        {
            if (ModelState.IsValid)
            {
                // PostgreSQL ke liye DateTime ko UTC banana zaroori hai
                model.DOB = DateTime.SpecifyKind(model.DOB, DateTimeKind.Utc);

                _context.ApplicationForms.Add(model);
                _context.SaveChanges();

                return RedirectToAction("ThankYou");
            }

            return View(model);
        }


        // GET: Thank You Page
        public IActionResult ThankYou()
        {
            return View();
        }
        // GET: Show All Submitted Records (Admin View)
        public IActionResult List()
        {
            var data = _context.ApplicationForms.ToList();
            return View(data);
        }
        // GET: Edit Record
        public IActionResult Edit(int id)
        {
            var record = _context.ApplicationForms.Find(id);

            if (record == null)
            {
                return NotFound();
            }

            return View(record);
        }
        // POST: Edit Record
        [HttpPost]
        public IActionResult Edit(ApplicationForm model)
        {
            if (ModelState.IsValid)
            {
                // Update ke time bhi DOB ko UTC banana zaroori hai
                model.DOB = DateTime.SpecifyKind(model.DOB, DateTimeKind.Utc);

                _context.ApplicationForms.Update(model);
                _context.SaveChanges();

                return RedirectToAction("List");
            }

            return View(model);
        }

        // GET: Delete Confirmation
        public IActionResult Delete(int id)
        {
            var record = _context.ApplicationForms.Find(id);

            if (record == null)
            {
                return NotFound();
            }

            return View(record);
        }
        // POST: Delete Confirmed
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var record = _context.ApplicationForms.Find(id);

            if (record != null)
            {
                _context.ApplicationForms.Remove(record);
                _context.SaveChanges();
            }

            return RedirectToAction("List");
        }



    }
}
