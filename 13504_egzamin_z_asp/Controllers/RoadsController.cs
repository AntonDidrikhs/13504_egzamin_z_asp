using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _13504_egzamin_z_asp.Models;
using System.Collections.Generic;

namespace _13504_egzamin_z_asp.Controllers
{
    public class RoadsController : Controller
    {
        private static IList<Road> road = new List<Road>()
        {

        };
        // GET: RoadsController
        public ActionResult Index()
        {
            return View(road);
        }

        // GET: RoadsController/Details/5

        // GET: RoadsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoadsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Road roadNew)
        {
            try
            {
                road.Add(roadNew);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoadsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoadsController/Edit/5
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

        // GET: RoadsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoadsController/Delete/5
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
