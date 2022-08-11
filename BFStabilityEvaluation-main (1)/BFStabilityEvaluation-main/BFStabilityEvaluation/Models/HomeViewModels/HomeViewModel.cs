using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BFStabilityEvaluation.Models.Entities;

namespace BFStabilityEvaluation.Models.HomeViewModels
{
    public class HomeViewModel
    {
        public List<IndicatorViewModel> Indicators { get; set; }

        public int CurrentIndicatorId { get; set; }

        public List<CriterionViewModel> Criterions { get; set; }

        public HomeViewModel()
        {
            Indicators = new List<IndicatorViewModel>();
            Criterions = new List<CriterionViewModel>();
        }
    }
}
