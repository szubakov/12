using System;
using System.Collections.Generic;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class StabilitySignKriterium
    {
        public int Id { get; set; }
        public int Npech { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double AcceptableDelta { get; set; }
        public double Rang { get; set; }
        public double ActionType { get; set; }
        public int IdstabPokaz { get; set; }
        public int IdParam { get; set; }

        public virtual Parameter IdParamNavigation { get; set; }
        public virtual StabilitySign IdstabPokazNavigation { get; set; }
    }
}
