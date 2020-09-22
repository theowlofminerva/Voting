using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class CandidateElection
    {
        public int CandidateId { get; set; }
        public int ElectionId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Election Election { get; set; }
    }
}
