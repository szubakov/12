using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Models.LoginViewModels
{

    public class LoginViewModel
    {
        [Display(Name = "Login")]
        public string Username{ get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }
}
