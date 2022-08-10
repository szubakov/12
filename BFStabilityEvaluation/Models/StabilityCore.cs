using BFStabilityEvaluation.Extension;
using System.Collections.Generic;
using System.Linq;

namespace BFStabilityEvaluation.Models
{
    public class StabilityCore
    {
        public static double GetStabilityValue(int indicatorId, List<StabilitySignKriterium> data)
        {
            var indicatorDatas = data.Where(d => d.StabSignId == indicatorId).ToList();
            
            var chislitel = 0d;
            var znam = indicatorDatas.Sum(x => x.Rang);

            foreach (var item in indicatorDatas)
            {
                var stdDev = item.Parameter.ParameterValues.Select(x => x.Value).StdDev();

                if (stdDev > item.AcceptableDelta) chislitel += item.Rang;
            }

            return chislitel * 100 / znam;
        }
    }
}
