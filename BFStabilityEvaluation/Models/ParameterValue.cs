using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class ParameterValue
    {
        public int Npech { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Value { get; set; }
        public int Period { get; set; }
        public int IdParam { get; set; }
        public int IdPValue { get; set; }

        public virtual Parameter IdParamNavigation { get; set; }

        [NotMapped]
        public SelectList IdParamNavigations { get; set; }
    }
}
