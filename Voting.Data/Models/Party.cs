using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class Party
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required] 
        public string PartyName { get; set; } = string.Empty;

        ////
        public IEnumerable<Candidate>? Candidates { get; set; }
        public IEnumerable<Voter>? Voters { get; set; }
    }
}
