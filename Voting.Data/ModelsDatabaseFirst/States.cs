using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class States
    {
        public States()
        {
            Cities = new HashSet<Cities>();
            Counties = new HashSet<Counties>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<Counties> Counties { get; set; }
    }
}
