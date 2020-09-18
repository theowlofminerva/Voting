using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Counties
    {
        public Counties()
        {
            Cities = new HashSet<Cities>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int? AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}
