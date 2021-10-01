using Microsoft.AspNetCore.Mvc;
using SelfManagement.Data;
using SelfManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfManagement.Controllers
{
    public class ExpenseTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpenseType> exList = _db.ExpenseTypes;
            return View(exList);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }
        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseType data)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseTypes.Add(data);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        // Delete
        
        public IActionResult Delete(int? id)
        {
            var obj = _db.ExpenseTypes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ExpenseTypes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        //get update

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpenseTypes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseType data)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseTypes.Update(data);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
