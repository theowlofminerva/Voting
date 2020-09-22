using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Voter
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string DriversLicenseNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string VoterRegistrationNumber { get; set; }

        [MaxLength(100)]
        public string Gender { get; set; }

        [MaxLength(100)]
        public string Ethnicity { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public int PartyId { get; set; }
       
        public ICollection<VoterElection> VoterElections { get; set; }
        public virtual Models.Party Party { get; set; }
        public virtual Models.Address Addresses { get; set; }
        public ICollection<Models.Vote> Votes { get; set; }

    }
}
