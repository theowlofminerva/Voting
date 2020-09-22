using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Office
    {
        public Office()
        {
            CandidateOffices = new HashSet<CandidateOffice>();
            Elections = new HashSet<Election>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TermLimit { get; set; }
        public int? OfficeTypeId { get; set; }
        public int? OfficeHolderId { get; set; }

        public virtual Candidate OfficeHolder { get; set; }
        public virtual OfficeType OfficeType { get; set; }
        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
        public virtual ICollection<Election> Elections { get; set; }
    }
}
