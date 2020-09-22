using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Voting.Data.Models;
using Voting.Web.Models.Vote;

namespace Voting.Web.Controllers
{
    public class VotesController : Controller
    {
        private readonly VotingContext _context;

        public VotesController(VotingContext context)
        {
            _context = context;
        }
        // GET: VotesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VotesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
    

            var election = await _context.Elections
                .Include(x => x.CandidateElections)
                .ThenInclude(y => y.Candidate)
                .Include(x => x.BallotIssues)
                .Include(x => x.Office)
                .Where(x => x.Id == 1)
                .FirstOrDefaultAsync();

            // figure out what election this is
            ViewBag.Title = election.Name;
            // also need render the ballot issues and checkbox for choosing

            var candidates = await _context.Candidates
                .Select(x => new SelectListItem { Text = $"{x.Party.PartyName.ToUpperInvariant()}: {x.FirstName} {x.LastName}", Value = x.Id.ToString() })
                .ToListAsync();

            // filter by election
            var ballotIssues = await _context.BallotIssues.Select(x => new BallotIssueViewModel
            {
                Description = x.Description, 
                ElectionId = x.ElectionId, 
                BallotIssueId = x.Id 

            }).ToListAsync();

            var vote = new CreateVoteViewModel { Candidates = candidates, BallotIssues = ballotIssues, ElectionId = ballotIssues.FirstOrDefault().ElectionId};

            return View(vote);
        }

        // POST: VotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateVoteViewModel model)
        {
            try
            {

                // filter list based on election, have to figure out how we know at the point you cast a vote
                var candidates = await _context.Candidates
                    .Select(x => new SelectListItem {Text = $"{x.Party.PartyName.ToUpperInvariant()}: {x.FirstName} {x.LastName}", Value = x.Id.ToString() })
                    .ToListAsync();

                var vote = new CreateVoteViewModel {Candidates = candidates};

                return View(vote);
            }
            catch
            {
                return View();
            }
        }

        // GET: VotesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VotesController/Edit/5
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

        // GET: VotesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VotesController/Delete/5
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
