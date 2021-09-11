using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsApp1 {
    class Calculator {
        public static double Sum(params double[] numbers) {
            double sum = 0.00;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
