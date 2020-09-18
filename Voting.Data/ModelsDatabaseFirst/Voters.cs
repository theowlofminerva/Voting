using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Voters
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string VoterRegistrationNumber { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public int PartyId { get; set; }
        public int? ElectionId { get; set; }

        public virtual Elections Election { get; set; }
        public virtual Parties Party { get; set; }
        public virtual Addresses Addresses { get; set; }
        public virtual Votes Votes { get; set; }
    }
}
