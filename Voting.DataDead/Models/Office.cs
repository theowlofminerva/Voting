using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Office
    {
        public Office()
        {
            Elections = new HashSet<Election>();
            CandidateOffices = new HashSet<CandidateOffice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TermLimit { get; set; }
        public int? OfficeTypeId { get; set; }
        public virtual OfficeType OfficeType { get; set; }
        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
        public virtual ICollection<Election> Elections { get; set; }
    }
}
