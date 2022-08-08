using BFStabilityEvaluation.Models.Enums;
using System;
using System.Collections.Generic;

namespace BFStabilityEvaluation.Models.RandomGeneratorModels
{
    public class RandomGeneratorModel
    {
        private Parameter Parameter { get; set; }

        private int NPech { get; set; }

        private DateTime DateBeg { get; set; }

        private DateTime DateEnd { get; set; }

        public RandomGeneratorModel(Parameter parameter, int nPech, DateTime dateBeg, DateTime dateEnd)
        {
            dateBeg = new DateTime(dateBeg.Year, dateBeg.Month, dateBeg.Day, 0, 0, 0);
            dateEnd = new DateTime(dateEnd.Year, dateEnd.Month, dateEnd.Day, 23, 59, 59);

            Parameter = parameter;
            NPech = nPech;
            DateBeg = dateBeg;
            DateEnd = dateEnd;
        }

        public List<ParameterValue> GetParameterValues(AsuPeriod period)
        {
            switch (period)
            {
                case AsuPeriod.Day:
                    return GetDay();

                case AsuPeriod.Hour:
                return GetHour();

                case AsuPeriod.Smena:
                    return GetSmena();

                    //case AsuPeriod.Week:
                    //    return GetWeek(model);
            }

            return null;
        }

        private List<ParameterValue> GetDay()
        {
            var parameterValues = new List<ParameterValue>();

            while (DateBeg < DateEnd)
            {
                var parameterValue = new ParameterValue
                {
                    Npech = NPech,
                    TimeStampEnd = DateBeg.AddDays(1).AddSeconds(-1),
                    TimeStampStart = DateBeg,
                    ParameterId = Parameter.ParameterId,
                    Value = GetParamaterRandomValue(Parameter),
                    Period = AsuPeriod.Day
                };

                parameterValues.Add(parameterValue);
                DateBeg = DateBeg.AddDays(1);
            }

            return parameterValues;
        }
        private List<ParameterValue> GetHour()
        {
            var parameterValues = new List<ParameterValue>();

            while (DateBeg < DateEnd)
            {
                var parameterValue = new ParameterValue
                {
                    Npech = NPech,
                    TimeStampEnd = DateBeg.AddHours(1).AddSeconds(-1),
                    TimeStampStart = DateBeg,
                    ParameterId = Parameter.ParameterId,
                    Value = GetParamaterRandomValue(Parameter),
                    Period = AsuPeriod.Hour
                };

                parameterValues.Add(parameterValue);
                DateBeg = DateBeg.AddHours(1);
            }

            return parameterValues;
        }
        private List<ParameterValue> GetSmena()
        {
            var parameterValues = new List<ParameterValue>();

            while (DateBeg < DateEnd)
            {
                var parameterValue = new ParameterValue
                {
                    Npech = NPech,
                    TimeStampEnd = DateBeg.AddHours(8).AddSeconds(-1),
                    TimeStampStart = DateBeg,
                    ParameterId = Parameter.ParameterId,
                    Value = GetParamaterRandomValue(Parameter),
                    Period = AsuPeriod.Smena
                };

                parameterValues.Add(parameterValue);
                DateBeg = DateBeg.AddHours(8);
            }

            return parameterValues;
        }


        private double GetParamaterRandomValue(Parameter parameter)
        {
            Random rnd = new();
            return rnd.NextDouble() * (parameter.MaxValue - parameter.MinValue) + parameter.MinValue;
        }
    }
}
