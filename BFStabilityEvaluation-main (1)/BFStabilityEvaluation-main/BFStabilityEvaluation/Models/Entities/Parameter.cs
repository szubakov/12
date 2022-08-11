using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BFStabilityEvaluation.Models.Entities
{
    public  class Parameter
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int ParameterId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(64)]
        public string Alias { get; set; }

        [StringLength(128)]
        public string Unit { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

        public  ICollection<ParameterValue> ParameterValues { get; set; }

        public  ICollection<SimpleCriterion> StabilitySignKriteria { get; set; }
    }
}
