using System;
using System.Collections.Generic;

namespace Statistics
{
	public class StatsAlerter
	{
		 float maxThreshold;
		 IAlerter[] alerters;

		public StatsAlerter(float maxThreshold, IAlerter[] alerters)
		{
			this.maxThreshold = maxThreshold;
			this.alerters = alerters;
		}

		public void checkAndAlert(List<float> numbers)
        {
			for(int i=0; i<numbers.Count; i++)
            {
                if (numbers[i] > this.maxThreshold)
                {
					for(int j=0; j < alerters.Length; j++)
                    {
						alerters[j].alert();
                    }
					break;
                }
            }
        }

	}
}
