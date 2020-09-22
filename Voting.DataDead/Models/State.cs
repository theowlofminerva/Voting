using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            Counties = new HashSet<County>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<County> Counties { get; set; }
    }
}
