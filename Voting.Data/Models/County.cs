using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class County
    {
        public County()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
