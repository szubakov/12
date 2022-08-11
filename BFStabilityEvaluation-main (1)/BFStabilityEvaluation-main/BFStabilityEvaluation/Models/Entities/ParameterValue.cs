using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BFStabilityEvaluation.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

#nullable disable

namespace BFStabilityEvaluation.Models.Entities
{
    public class ParameterValue
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Номер печи")]
        [Required(ErrorMessage = "Введите номер печи")]
        public int Npech { get; set; }

        [Display(Name = "Метка времени (начало периода)")]
        [Required(ErrorMessage = "Введите метку времени (начало периода)")]
        public DateTime TimeStampStart { get; set; }

        [Display(Name = "Метка времени (конец периода)")]
        [Required(ErrorMessage = "Введите метку времени (конец периода)")]
        public DateTime TimeStampEnd { get; set; }

        public double Value { get; set; }

        [Display(Name = "Период")]
        public AsuPeriod Period { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ParameterId { get; set; }

        [Display(Name = "Параметр")]
        public Parameter Parameter { get; set; }

        [NotMapped]
        public SelectList IdParamNavigations { get; set; }
    }

    public enum PeriodList
    {
        [Display(Name = "По часам")]
        Hour = 1,
        [Display(Name = "По сменам")]
        Smena = 2,
        [Display(Name = "По дням")]
        Day = 3,
        [Display(Name = "По неделям")]
        Week = 4
    }
}
