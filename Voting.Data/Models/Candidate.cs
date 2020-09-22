using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateElections = new HashSet<CandidateElection>();
            CandidateOffices = new HashSet<CandidateOffice>();
            Elections = new HashSet<Election>();
            Offices = new HashSet<Office>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public int PartyId { get; set; }

        public virtual Party Party { get; set; }
        public virtual ICollection<CandidateElection> CandidateElections { get; set; }
        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
        public virtual ICollection<Election> Elections { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
