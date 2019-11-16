using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDataBase())
            {
                var books = db.Books.ToList();
                return this.View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, decimal price)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDataBase())
            {
                Book book = new Book
                {
                    Title = title,
                    Author = author,
                    Price = price
                };
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDataBase())
            {
                Book bookToedit = db.Books.Find(id);
                return View(bookToedit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new LibraryDataBase())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDataBase())
            {
                Book bookToDelete = db.Books.FirstOrDefault(t => t.Id == id);
                if(bookToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDataBase())
            {
                var bookToDelete = db.Books.FirstOrDefault(t => t.Id == book.Id);
                if (bookToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}