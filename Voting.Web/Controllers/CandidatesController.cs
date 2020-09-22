using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Voting.Data.Models;
using Voting.Web.Models.Candidate;

namespace Voting.Web.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly VotingContext _context;

        public CandidatesController(VotingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            try
            {
                var candidates = await _context.Candidates.ToListAsync();

                return View(candidates);

            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }

        }

      

        // GET: CandidateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidateController/Create
        public async Task<IActionResult> Create()
        {

            var parties = await _context.Parties.Select(x => new SelectListItem {Text = x.PartyName, Value = x.Id.ToString() }).ToListAsync();
            var model = new CreateCandidateViewModel {Parties = parties};

            return View(model);
        }

        // POST: CandidateController/Create
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

        // GET: CandidateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandidateController/Edit/5
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

        // GET: CandidateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandidateController/Delete/5
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
