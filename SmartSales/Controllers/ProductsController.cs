#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartSales.Data;
using SmartSales.Models;

namespace SmartSales.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }

        // GET: Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Product
                .FirstOrDefault(m => m.Product_ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewBag.Category_ID = new SelectList(_context.Category.FromSqlRaw("select * from Category").ToList(), "Category_Id", "Category_Name");
            ViewBag.Stock_ID = new SelectList(_context.Stock.FromSqlRaw("select * from Stock").ToList(), "Stock_ID", "Stock_Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Product.Find(id);
            ViewBag.Category_ID = new SelectList(_context.Category.FromSqlRaw("select * from Category").ToList(), "Category_Id", "Category_Name");
            ViewBag.Stock_ID = new SelectList(_context.Stock.FromSqlRaw("select * from Stock").ToList(), "Stock_ID", "Stock_Name");
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Product product)
        {
            if (id != product.Product_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Product_ID))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Product
                .FirstOrDefault(m => m.Product_ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Product.Find(id);
            _context.Product.Remove(product);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Product_ID == id);
        }


        public ActionResult AddQuantity()
        {
            ViewBag.Product_Name = new SelectList(_context.Product.FromSqlRaw("select * from product").ToList(), "Product_ID", "Product_Name");
            return View();
        }

        //public JsonResult GetProNameont(string proid)
        //{
        //    string probarcode = _context.Product.FromSqlRaw("select * from product" , proid).FirstOrDefault().Product_Barcode;
        //    return Json(
        //        new
        //        {
        //            probarcode,
        //            proid
        //        });
        //}

        //public JsonResult AddADQU(string barcode , string quan, string proname)
        //{
        //    _context.Database.ExecuteSqlRaw()
        //    return Json(
        //        new
        //        {
        //            probarcode,
        //            proid
        //        });
        //}

        //public JsonResult GetProductBarAndPricev(string probarcode)
        //{
        //    int proid * _context.Product.FromSqlRaw("select * from product", proid).FirstOrDefault().Product_Barcode;
        //    return Json(
        //        new
        //        {
        //            proid
        //        });
        //}
    }
}
