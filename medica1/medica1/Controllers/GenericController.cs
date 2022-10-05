using medica1.Context;
using medica1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace medica1.Controllers
{
    public class GenericController : Controller
    {
        MVCContext db;
        private int id;

        public GenericController(MVCContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<Generic_Name> generic_Names = db.Generic_Names.Select(s => s).ToList();
            return View( generic_Names);
        }
        public ActionResult Create(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Generic_Name _Generic)
        {
            Generic_Name generic_Name = db.Generic_Names.FirstOrDefault(s => s.ID ==id);
            if(ModelState.IsValid)
            {
                db.Generic_Names.Add(_Generic);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }
        public IActionResult Delete(int id)
        {
           Generic_Name generic_Name = db.Generic_Names.FirstOrDefault(s => s.ID == id);
            if(generic_Name != null)
            {
                db.Generic_Names.Remove(generic_Name);
                db.SaveChanges();
                return RedirectToAction("Index");
                      
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Generic_Name generic_Name = db.Generic_Names.Find(id);
            if(generic_Name == null)
            {
                return HttpNotFound();
            }
            return View(generic_Name);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public IActionResult Edit(Generic_Name ge)
        {
            db.Entry(ge).State=EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Generic_Name generic_Name = db.Generic_Names.FirstOrDefault(s => s.ID == id);
            if( generic_Name != null)
            {
                return View(generic_Name);
            }
            return View();
        }
    }
}
