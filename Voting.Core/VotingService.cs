using System;
using System.Collections.Generic;
using System.Text;
using Voting.Data;

namespace Voting.Core
{
    public class VotingService
    {
        private readonly VotingContext _context;

        public VotingService(VotingContext context)
        {
            _context = context;
        }



    }
}
