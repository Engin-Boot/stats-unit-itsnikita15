using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;
      

        public StatsComputer()
        {
            this.average = 0.0;
            this.max = 0.0;
            this.min = Double.MaxValue;
        }
        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats Results = new Stats();

            if(numbers.Count == 0)
            {
                Results.average = Double.NaN;
                Results.max = Double.NaN;
                Results.min = Double.NaN;
                return Results;
            }

            for(int i=0; i<numbers.Count; i++)
            {
                this.average += numbers[i];
                this.max = Math.Max(this.max, numbers[i]);
                this.min = Math.Min(this.min, numbers[i]);
            }

            this.average = this.average/ numbers.Count;
            Results.average = this.average;
            Results.max = this.max;
            Results.min = this.min;
            return Results;
        }
    }
}
