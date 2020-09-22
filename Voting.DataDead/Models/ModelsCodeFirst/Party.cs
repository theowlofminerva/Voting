using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Party
    {
        public Party()
        {
            Candidates = new HashSet<Models.Candidate>();
            Voters = new HashSet<Voter>();
        }

        public int Id { get; set; }

        [MaxLength(250)]
        public string PartyName { get; set; }

        public virtual ICollection<Models.Candidate> Candidates { get; set; }
        public virtual ICollection<Voter> Voters { get; set; }
    }
}
