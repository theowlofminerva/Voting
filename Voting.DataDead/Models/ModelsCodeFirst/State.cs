using System;
using System.Collections.Generic;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class State
    {
        public State()
        {
            Cities = new HashSet<Models.City>();
            Counties = new HashSet<Models.County>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }

        public virtual Models.Address Address { get; set; }
        public virtual ICollection<Models.City> Cities { get; set; }
        public virtual ICollection<Models.County> Counties { get; set; }

    }
}
