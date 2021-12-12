using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp2.Services
{
    class CalculationService
    {
        public int Max(List<int> list)
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty!");
            }

            int max = list[0];
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
