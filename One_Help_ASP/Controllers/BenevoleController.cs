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
    public class BenevoleController : Controller
    {
        private readonly MyDbContext _context;
        public BenevoleController(MyDbContext context)
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
            var benevole = _context.Benevole.ToList();
            return View(benevole);
        }

       //Get-create
        public IActionResult Create()
        {
            return View();
        }

        //Post-create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Benevole benevole)
        {
            if (ModelState.IsValid)
            {
                _context.Benevole.Add(benevole);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(benevole);
        }


        //get-Delete
       
      
        public IActionResult Delete(int? id)
        {
           
            if (id == null || id==0)
            {
                return NotFound();
            }
            var benevole = _context.Benevole.Find(id);
            if (benevole == null)
            {
                return NotFound();
            }
            return View(benevole);

        }
        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var benevole = _context.Benevole.Find(id);
            if(benevole== null)
            {
                return NotFound();
            }
              
                _context.Benevole.Remove(benevole);
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
            var benevole = _context.Benevole.Find(id);
            if (benevole == null)
            {
                return NotFound();
            }
            return View(benevole);

        }

        //Post-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Benevole benevole)
        {
            if (ModelState.IsValid)
            {
                _context.Benevole.Update(benevole);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(benevole);
        }

        //get detail
        public IActionResult Detail(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var benevole = _context.Benevole.Find(id);
            if (benevole == null)
            {
                return NotFound();
            }
            return View(benevole);

        }

    }
}
