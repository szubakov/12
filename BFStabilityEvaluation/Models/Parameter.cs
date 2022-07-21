using System;
using System.Collections.Generic;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class Parameter
    {
        public Parameter()
        {
            ParameterValues = new HashSet<ParameterValue>();
            StabilitySignKriteria = new HashSet<StabilitySignKriterium>();
        }

        public int IdParam { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Unit { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public virtual ICollection<ParameterValue> ParameterValues { get; set; }
        public virtual ICollection<StabilitySignKriterium> StabilitySignKriteria { get; set; }
    }
}
