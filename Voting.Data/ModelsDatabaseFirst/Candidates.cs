using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Candidates
    {
        public Candidates()
        {
            Votes = new HashSet<Votes>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public bool? IsIncumbent { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public int PartyId { get; set; }
        public int? OfficeId { get; set; }
        public int? ElectionId { get; set; }

        public virtual Elections Election { get; set; }
        public virtual Offices Office { get; set; }
        public virtual Parties Party { get; set; }
        public virtual ICollection<Votes> Votes { get; set; }
    }
}
