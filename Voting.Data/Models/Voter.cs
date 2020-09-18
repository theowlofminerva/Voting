using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class Voter
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string DriversLicenseNumber { get; set; } = string.Empty;

        [Required]
        public string VoterRegistrationNumber { get; set; } = string.Empty;

        public string? Gender { get; set; }

        public string? Ethnicity { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        public Address Address { get; set; } = new Address();
         
        ////

        [Required]
        public int PartyId { get; set; }
        
        [Required]
        public Party Party { get; set; } = new Party();

        public int? ElectionId { get; set; }

        public Election? Election { get; set; }

        public Vote? Vote { get; set; }


    }
}
