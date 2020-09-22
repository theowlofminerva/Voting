using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Office
    {

        public Office()
        {
            Elections = new HashSet<Models.Election>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public string? TermLimit { get; set; }

        public int? OfficeTypeId { get; set; }

        public virtual OfficeType OfficeType { get; set; }
        public Models.Candidate Candidate { get; set; }
        public int CandidateId { get; set; }

        public virtual ICollection<Models.Election> Elections { get; set; }

    }
}
