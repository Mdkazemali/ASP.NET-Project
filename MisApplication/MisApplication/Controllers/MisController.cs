using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MisApplication.Context;
using MisApplication.Models;

namespace MisApplication.Controllers
{
    public class MisController : Controller
    {
        MVCContex db;
        public MisController(MVCContex _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<mis> miss = db.mis.Select(s => s).ToList();
            return View(miss);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(mis Mis)
        {
            if (ModelState.IsValid)
            {
                db.mis.Add(Mis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            mis miss = db.mis.FirstOrDefault(mis => mis.Id == id);
            if (miss != null)
            {
                db.mis.Remove(miss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            mis miss = db.mis.Find(id);
            if(miss == null)
            {
                return HttpNOtFound();
            }
            return View(miss);
        }

        private IActionResult HttpNOtFound()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public IActionResult Edit(mis miss)
        {
            db.Entry(miss).State=EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            mis miss=db.mis.FirstOrDefault(mis=>mis.Id==id);
            if (miss != null)
            {
                return View(miss);  
            }
            return View();
        }
    }
}
