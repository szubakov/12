using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BFStabilityEvaluation.Models;


namespace BFStabilityEvaluation.Models
{
    public class HomeViewModel
    {
        public IEnumerable<ParameterValue> ParameterValues { get; set; }
        public IEnumerable<StabilitySignKriterium> StabilitySignKriteriums { get; set; }

    }
}
