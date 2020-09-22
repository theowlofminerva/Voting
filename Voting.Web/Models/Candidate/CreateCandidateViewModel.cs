using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Voting.Data.Models;

namespace Voting.Web.Models.Candidate
{
    [Serializable]
    public class CreateCandidateViewModel
    {
        [MaxLength(100)]
        [DisplayName("First Name")]
        [Required] 
        public string FirstName { get; set; }

        [MaxLength(100)]
        [DisplayName("Last Name")]
        [Required] 
        public string LastName { get; set; }

        [DisplayName("Political Party")]
        [Required] 
        public IEnumerable<SelectListItem> Parties { get; set; }

        [MaxLength(100)]
        [DisplayName("Ethnicity")]
        public string Ethnicity { get; set; }

        [MaxLength(100)]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Date of Birth")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}{1:HH/mm}")]
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
