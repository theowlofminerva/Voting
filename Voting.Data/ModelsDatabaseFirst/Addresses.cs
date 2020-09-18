using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Addresses
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public int VoterId { get; set; }
        public int? PrecinctId { get; set; }

        public virtual Precincts Precinct { get; set; }
        public virtual Voters Voter { get; set; }
        public virtual Cities Cities { get; set; }
        public virtual Counties Counties { get; set; }
        public virtual States States { get; set; }
    }
}
