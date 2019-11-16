using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandDataBase())
            {
                var bands = db.Bands.ToList();
                return this.View(bands);
        }
    }

        [HttpGet]
        public IActionResult Create()
        {
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(string name, string members,decimal honorarium,string genre)
        {
            using (var db = new BandDataBase())
            {
                Band bandName = new Band {
                    Name = name,
                    Members = members,
                    Honorarium = honorarium,
                    Genre = genre           
            };
            db.Bands.Add(bandName);
            db.SaveChanges();
        }
            return RedirectToAction("Index");
    }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandDataBase())
            {
                var bandToEdit = db.Bands.Find(id);
                return View(bandToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var db = new BandDataBase())
            {
                db.Bands.Update(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandDataBase())
            {
                var bandToDelete = db.Bands.Find(id);
                return View(bandToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandDataBase())
            {
                var bandToDelete = db.Bands.Remove(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}