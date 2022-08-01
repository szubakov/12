using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public  class StabilitySign
    {
       

        [HiddenInput(DisplayValue = false)]
        [Key]
        public int StabSignId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Alias { get; set; }

        public double LimitWarning { get; set; }
        public double LimitDanger { get; set; }

        public  ICollection<StabilitySignKriterium> StabilitySignKriteria { get; set; }
    }
}
