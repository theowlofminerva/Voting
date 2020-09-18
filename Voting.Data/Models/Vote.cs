using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class Vote
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Candidate? Candidate { get; set; }

        public int? CandidateId { get; set; }

        [Required]
        public Voter Voter { get; set; } = new Voter();

        [Required]
        public int VoterId { get; set; }

        public IEnumerable<BallotIssue>? BallotIssues { get; set; }
    }
}
