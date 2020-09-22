using System;
using System.Collections.Generic;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class OfficeType
    {
        public OfficeType()
        {
            Offices = new HashSet<Models.Office>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Models.Office> Offices { get; set; }
    }
}
