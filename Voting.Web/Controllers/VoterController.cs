using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Voting.Data;

namespace Voting.Web.Controllers
{
    [Route("api/[controller]")]
    public class VoterController : Controller
    {
        private readonly VotingContext _context;

        public VoterController(VotingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCandidates()
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
    }
}
