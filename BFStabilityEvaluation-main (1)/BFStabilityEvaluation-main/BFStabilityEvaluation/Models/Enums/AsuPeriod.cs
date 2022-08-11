using System.ComponentModel;

namespace BFStabilityEvaluation.Models.Enums
{
    public enum AsuPeriod
    {
        [Description("По часам")]
        Hour = 1,

        [Description("По сменам")]
        Smena = 2,

        [Description("По дням")]
        Day = 3,

        [Description("По неделям")]
        Week = 4,

        [Description("По месяцам")]
        Month = 5,

        [Description("По выпускам")]
        Vipusk = 6
    }
}
