﻿using LibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/Random
        public IActionResult Random()
        {
            var firstBook = new Book()
            {
                Author = "Test",
                Id = 123,
                Title = "Random title"
            };

            ViewBag.Book = firstBook;
            ViewData["FirstBook"] = firstBook;

            return View();
            //return RedirectToAction("Index", "Book", new { page = 1, sortBy="title"});
        }

        // GET: BooksController/{pageIndex}&{sortBy}
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "title";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //// GET: BooksController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
