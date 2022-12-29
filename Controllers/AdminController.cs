using DemoProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class AdminController : Controller
    {

        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context);
        }

        /*[HttpGet]
        public IActionResult Product_CRUD()
        {
            return View(_context.Products.ToList());
        }

        [HttpGet]
        public IActionResult ADD()
        {

            return View();
        }


        [HttpPost]
        public IActionResult ADD(Products p)
        {

            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Product_crud", "Admin");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Products res = _context.Products.Find(id);

            return View(res);
        }


        [HttpPost]
        public IActionResult Edit(Products p)
        {

            _context.Products.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Product_crud", "Admin");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Products res = _context.Products.Find(id);

            return View(res);
        }


        [HttpPost]
        public IActionResult Delete(int id, Products p)
        {


            Products pp = _context.Products.Find(id);
            _context.Products.Remove(pp);
            _context.SaveChanges();
            return RedirectToAction("Product_crud", "Admin");
        }*/


    }
}
