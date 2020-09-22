using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Voting.Data.Models;

namespace Voting.Web.Models.Vote
{
    [Serializable]
    public class CreateVoteViewModel
    {
        [Required]
        public List<SelectListItem> Candidates { get; set; }

        public List<BallotIssueViewModel> BallotIssues { get; set; }

        public int ElectionId { get; set; }

        public int CandidateId { get; set; }
    }

    public class BallotIssueViewModel
    {
        [Required]
        [DisplayName("Issue Description")]
        public string Description { get; set; }

        [Required]
        public int ElectionId { get; set; }

        [Required]
        [DisplayName("Yea")]
        public bool IsYea { get; set; }

        [Required]
        public int BallotIssueId { get; set; }
    }
}
