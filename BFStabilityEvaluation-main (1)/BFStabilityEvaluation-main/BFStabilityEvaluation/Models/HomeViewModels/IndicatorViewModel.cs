using BFStabilityEvaluation.Models.Enums;

namespace BFStabilityEvaluation.Models.HomeViewModels
{
    public class IndicatorViewModel
    {
        public int IndicatorId { get; set; }

        public string Name { get; set; }

        public IndicatorType Type { get; set; }

        public double Value { get; set; }

        public double LimitWarning { get; set; }

        public double LimitDanger { get; set; }
    }
}
