using System;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public int VoterId { get; set; }
        public int? PrecinctId { get; set; }

        public virtual Precinct Precinct { get; set; }
        public virtual Voter Voter { get; set; }
        public virtual City City { get; set; }
        public virtual County County { get; set; }
        public virtual State State { get; set; }
    }

}
