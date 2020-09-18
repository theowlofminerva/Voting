using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class OfficeTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Offices Offices { get; set; }
    }
}
