using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CodeUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte? Role { get; set; }

     
    }
}