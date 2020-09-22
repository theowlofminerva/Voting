using System;
using System.Collections.Generic;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class County
    {
        public County()
        {
            Cities = new HashSet<Models.City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int? AddressId { get; set; }

        public virtual Models.Address Address { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Models.City> Cities { get; set; }

    }

}
