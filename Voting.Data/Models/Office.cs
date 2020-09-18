using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class Office
    {
        [Key]
        [Required]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; } = string.Empty;

        public Candidate? CurrentOccupant { get; set; }

        public DateTimeOffset? NextElectionDate { get; set; }

        public OfficeType? OfficeType { get; set; }

        public int? OfficeTypeId { get; set; }
    }
}
