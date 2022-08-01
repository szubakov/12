using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public  class StabilitySignKriterium
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int? Id { get; set; }

        public int? Npech { get; set; }

        [StringLength(255)]
        public string? Name { get; set; }

        [StringLength(128)]
        public string Unit { get; set; }

        public double AcceptableDelta { get; set; }
        public double Rang { get; set; }
        public double ActionType { get; set; }

        [ForeignKey(nameof(IdstabPokazNavigation))]
        public int StabSignId { get; set; }

        public int ParameterId { get; set; }

        public Parameter Parameter { get; set; }

        public StabilitySign IdstabPokazNavigation { get; set; }

        [NotMapped]
        public SelectList IdParamNavigations { get; set; }

        [NotMapped]
        public SelectList IdstabPokazNavigations { get; set; }
    }
}
