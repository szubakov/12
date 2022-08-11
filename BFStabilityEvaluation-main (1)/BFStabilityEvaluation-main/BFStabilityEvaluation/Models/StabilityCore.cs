using BFStabilityEvaluation.Extension;
using BFStabilityEvaluation.Models.Entities;
using BFStabilityEvaluation.Models.HomeViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BFStabilityEvaluation.Models
{
    public class StabilityCore
    {
        public static double GetStabilitySimpleValue(List<CriterionViewModel> criterionsData)
        {
            var chislitel = criterionsData.Where(item => item.StdDevValue <= item.AcceptableDelta).Sum(x => x.Rang);
            var znam = criterionsData.Sum(x => x.Rang);

            return chislitel * 100 / znam;
        }

        public static double GetStabilityComplexValue(List<ComplexCriterion> criterionsData, List<IndicatorViewModel> indicatorsData)
        {
            var chislitel = 0d;
            var znam = criterionsData.Sum(x => x.Rang);

            foreach(var criterion in criterionsData)
            {
                var indicator = indicatorsData.FirstOrDefault(x => x.IndicatorId == criterion.IndicatorId);
                if (indicator != null) chislitel += (indicator.Value / 100d);
            }

            return chislitel * 100 / znam;
        }
    }
}
