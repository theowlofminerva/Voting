using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Address1 { get; set; } = string.Empty;

        public string? Address2 { get; set; }

        [Required]
        public City City { get; set; } = new City();

        [Required]
        public County County { get; set; } = new County();

        [Required]
        public State State { get; set; } = new State();

        [Required]
        public string ZipCode { get; set; } = string.Empty;

        ////
        public Voter? Voter { get; set; }

        public int VoterId { get; set; }

        public Precinct? Precinct { get; set; }

        public int? PrecinctId { get; set; }
    }

}
