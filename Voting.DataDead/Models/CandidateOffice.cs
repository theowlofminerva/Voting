using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class CandidateOffice
    {

        public Candidate Candidate { get; set; }

        [Key]
        public int CandidateId { get; set; }

        public Office Office { get; set; }

        [Key]
        public int OfficeId { get; set; }
    }
}
