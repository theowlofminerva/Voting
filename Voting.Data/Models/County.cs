using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voting.Data.Models
{
    [Serializable]
    public class County
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

        public Address? Address { get; set; }
        public int? AddressId { get; set; }

        public IEnumerable<City>? Cities { get; set; }

    }

}
