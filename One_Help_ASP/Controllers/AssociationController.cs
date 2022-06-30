using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using One_Help_ASP.Data;
using One_Help_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace One_Help_ASP.Controllers
{
    public class AssociationController : Controller
    {
        private readonly MyDbContext _context;
        public AssociationController(MyDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            try
            {
                if (HttpContext.Session.GetString("email") == null)
                {
                    return RedirectToAction("Login", "User");
                }

            }
            catch
            {
                return RedirectToAction("Login", "User");
            }


            var association = _context.Association.ToList();
            return View(association);
        }

        //Get-create
        public IActionResult Create()
        {
            return View();
        }

        //Post-create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Association association)
        {
            if (ModelState.IsValid)
            {
                _context.Association.Add(association);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(association);
        }


        //get-Delete


        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var association = _context.Association.Find(id);
            if (association == null)
            {
                return NotFound();
            }
            return View(association);

        }
        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var association = _context.Association.Find(id);
            if (association == null)
            {
                return NotFound();
            }

            _context.Association.Remove(association);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        //get update
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var association = _context.Association.Find(id);
            if (association == null)
            {
                return NotFound();
            }
            return View(association);

        }

        //Post-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Association association)
        {
            if (ModelState.IsValid)
            {
                _context.Association.Update(association);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(association);
        }

        //get detail
        public IActionResult Detail(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var association = _context.Association.Find(id);
            if (association == null)
            {
                return NotFound();
            }
            return View(association);

        }
    }
}
