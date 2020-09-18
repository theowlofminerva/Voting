using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Parties
    {
        public Parties()
        {
            Candidates = new HashSet<Candidates>();
            Voters = new HashSet<Voters>();
        }

        public int Id { get; set; }
        public string PartyName { get; set; }

        public virtual ICollection<Candidates> Candidates { get; set; }
        public virtual ICollection<Voters> Voters { get; set; }
    }
}
