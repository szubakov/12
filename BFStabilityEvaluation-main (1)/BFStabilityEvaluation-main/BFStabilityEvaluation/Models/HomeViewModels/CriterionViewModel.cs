namespace BFStabilityEvaluation.Models.HomeViewModels
{
    public class CriterionViewModel
    {
        public string Name { get; set; }

        public string Unit { get; set; }

        public double AcceptableDelta { get; set; }

        public double Rang { get; set; }

        public int IndicatorId { get; set; }

        public double AverageValue { get; set; }

        public double StdDevValue { get; set; }
    }
}
