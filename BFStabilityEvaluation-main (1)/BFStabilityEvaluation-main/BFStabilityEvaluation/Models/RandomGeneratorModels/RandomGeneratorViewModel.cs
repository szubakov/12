using System;
using System.ComponentModel.DataAnnotations;

namespace BFStabilityEvaluation.Models.RandomGeneratorModels
{
    public class RandomGeneratorViewModel
    {
        [Display(Name = "Номер печи")]
        public int Npech { get; set; }

        [Display(Name = "Начало периода")]
        public DateTime DateBeg { get; set; }

        [Display(Name = "Конец периода")]
        public DateTime DateEnd { get; set; }
    }
}
