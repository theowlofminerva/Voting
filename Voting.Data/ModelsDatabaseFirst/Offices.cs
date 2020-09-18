using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Offices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? NextElectionDate { get; set; }
        public int? OfficeTypeId { get; set; }

        public virtual OfficeTypes OfficeType { get; set; }
        public virtual Candidates Candidates { get; set; }
    }
}
