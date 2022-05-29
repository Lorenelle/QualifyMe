using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QualifyMe.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string StudentID { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
