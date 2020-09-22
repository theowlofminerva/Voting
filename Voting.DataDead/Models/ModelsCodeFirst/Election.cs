using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Voting.Data.Models.ModelsCodeFirst
{

    [Serializable]
    public class Election
    {
        public Election()
        {
            BallotIssues = new HashSet<Models.BallotIssue>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(350)]
        public string Name { get; set; }

        public Office Office { get; set; }
        public int OfficeId { get; set; }
        public Models.Candidate Winner { get; set; }
        public int WinnerId { get; set; }


        public DateTimeOffset ElectionDate { get; set; }

        public virtual ICollection<Models.BallotIssue> BallotIssues { get; set; }
        public ICollection<VoterElection> VoterElections { get; set; }

        public ICollection<Models.CandidateElection> CandidateElections { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
