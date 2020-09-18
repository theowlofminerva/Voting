using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Precincts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Addresses Addresses { get; set; }
    }
}
