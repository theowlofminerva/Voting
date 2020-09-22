using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Voting.Web.Models.Office
{
    [Serializable]
    public class CreateOfficeViewModel
    {
        [DisplayName("Office Name")]
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Term Limit")]
        [MaxLength(50)]
        public string TermLimit { get; set; }
    }
}
