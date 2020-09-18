using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Voting.Data.Models
{
    [Serializable]
    public class Candidate
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        public bool? IsIncumbent { get; set; }

        public string? Gender { get; set; }
        public string? Ethnicity { get; set; }

        ////

        [Required]
        public int PartyId { get; set; }


        [Required]
        public Party Party { get; set; } = new Party();

        public IEnumerable<Vote>? Votes { get; set; }

        public Office? Office { get; set; }

        public int? OfficeId { get; set; }

    }
}
