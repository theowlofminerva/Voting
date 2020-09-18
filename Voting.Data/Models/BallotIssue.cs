using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class BallotIssue
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required] public string Description { get; set; } = string.Empty;

        public bool IsYea { get; set; }

        ////
        public Vote? Vote { get; set; }

        public int? VoteId { get; set; }

        public Election Election { get; set; } = new Election();

        public int ElectionId { get; set; }
    }
}
