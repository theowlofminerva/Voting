using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Voting.Data.Models
{

    [Serializable]
    public class City
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;


        [Required]
        public State State { get; set; } = new State();

        [Required]
        public int StateId { get; set; }

        [Required]
        public County County { get; set; } = new County();

        [Required]
        public int CountyId { get; set; }
        public Address? Address { get; set; }
        public int? AddressId { get; set; }
    }
}
