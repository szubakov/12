using BFStabilityEvaluation.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BFStabilityEvaluation.Models.Entities
{
    public class Indicator
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int IndicatorId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Alias { get; set; }

        public IndicatorType Type { get; set; }

        public double LimitWarning { get; set; }

        public double LimitDanger { get; set; }

        public int Order { get; set; }

        public  ICollection<SimpleCriterion> StabilitySignKriteria { get; set; }
    }
}
