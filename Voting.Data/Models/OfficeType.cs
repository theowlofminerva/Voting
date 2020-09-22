using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class OfficeType
    {
        public OfficeType()
        {
            Offices = new HashSet<Office>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
    }
}
