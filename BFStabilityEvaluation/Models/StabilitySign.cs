using System;
using System.Collections.Generic;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class StabilitySign
    {
        public StabilitySign()
        {
            StabilitySignKriteria = new HashSet<StabilitySignKriterium>();
        }

        public int IdstabPokaz { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public double LimitWarning { get; set; }
        public double LimitDanger { get; set; }

        public virtual ICollection<StabilitySignKriterium> StabilitySignKriteria { get; set; }
    }
}
