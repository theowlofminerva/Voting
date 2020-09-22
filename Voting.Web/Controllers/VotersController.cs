using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Voting.Data.Models;

namespace Voting.Web.Controllers
{
    public class VotersController : Controller
    {
        private readonly VotingContext _context;

        public VotersController(VotingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



    }
}