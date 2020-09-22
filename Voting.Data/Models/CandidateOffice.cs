using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class CandidateOffice
    {
        public int CandidateId { get; set; }
        public int OfficeId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Office Office { get; set; }
    }
}
