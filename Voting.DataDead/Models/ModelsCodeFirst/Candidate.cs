using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Candidate
    {
        public Candidate()
        {
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

        [MaxLength(100)]
        public string Gender { get; set; }

        [MaxLength(100)]
        public string Ethnicity { get; set; }
        public int PartyId { get; set; }
        public Office? Office { get; set; }
        public ICollection<Election> ElectionsWon { get; set; }
        public virtual Party Party { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }

        public ICollection<CandidateElection> CandidateElections { get; set; }

    }
}
