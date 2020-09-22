using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public int VoterId { get; set; }
        public int? PrecinctId { get; set; }

        public virtual Precinct Precinct { get; set; }
        public virtual Voter Voter { get; set; }
        public virtual City Cities { get; set; }
        public virtual County Counties { get; set; }
        public virtual State States { get; set; }
    }
}
