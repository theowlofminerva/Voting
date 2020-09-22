using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Voter
    {
        public Voter()
        {
            VoterElections = new HashSet<VoterElection>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string VoterRegistrationNumber { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public int PartyId { get; set; }

        public virtual Party Party { get; set; }
        public virtual Address Addresses { get; set; }
        public virtual ICollection<VoterElection> VoterElections { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
