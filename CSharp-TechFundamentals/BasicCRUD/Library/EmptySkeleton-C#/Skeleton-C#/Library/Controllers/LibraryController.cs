using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            //TO DO
            return null;
        }

        [HttpGet]
        public IActionResult Create()
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            //TO DO
            return null;
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            //TO DO
            return null;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            //TO DO
            return null;
        }
    }
}