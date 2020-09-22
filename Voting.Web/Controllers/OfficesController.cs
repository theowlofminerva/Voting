using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Voting.Web.Controllers
{
    public class OfficesController : Controller
    {
        // GET: OfficesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OfficesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OfficesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficesController/Create
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

        // GET: OfficesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfficesController/Edit/5
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

        // GET: OfficesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfficesController/Delete/5
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
