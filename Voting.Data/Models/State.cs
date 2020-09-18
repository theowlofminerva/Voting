using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class State
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public Address? Address { get; set; }
        public int? AddressId { get; set; }
        public IEnumerable<City>? Cities { get; set; }
        public IEnumerable<County>? Counties { get; set; }

    }
}
