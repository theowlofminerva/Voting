using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{

    [Serializable]
    public class Election
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTimeOffset ElectionDate { get; set; }

        public int? TotalVotes { get; set; }

        ////
        public IEnumerable<Candidate>? Candidates { get; set; }
        public IEnumerable<Voter>? Voters { get; set; }

        private IEnumerable<BallotIssue>? BallotIssues { get; set; }
    }
}
