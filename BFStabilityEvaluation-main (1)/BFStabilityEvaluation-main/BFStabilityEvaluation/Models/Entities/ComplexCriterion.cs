using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BFStabilityEvaluation.Models.Entities
{
    public  class ComplexCriterion
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int? Id { get; set; }

        public int? Npech { get; set; }

        public double Rang { get; set; }
        
        [ForeignKey(nameof(Indicator))]
        public int IndicatorId { get; set; }

        //[ForeignKey(nameof(СalculatedIndicator))]
        public int СalculatedIndicatorId { get; set; }

        public Indicator Indicator { get; set; }

        //public Indicator СalculatedIndicator { get; set; }
    }
}
