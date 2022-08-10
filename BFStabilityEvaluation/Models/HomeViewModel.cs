using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BFStabilityEvaluation.Models;


namespace BFStabilityEvaluation.Models
{
    public class HomeViewModel
    {
        public List<StabilitySign> StabilitySigns { get; set; }

        public int CurrentSignId { get; set; }

        //public IEnumerable<ParameterValue> ParameterValues { get; set; }

        public List<StabilitySignKriterium> StabilitySignKriteriums { get; set; }

    }
}
