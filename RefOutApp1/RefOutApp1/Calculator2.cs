using System;
using System.Collections.Generic;
using System.Text;

namespace RefOutApp1 {
    // utilizando o out
    class Calculator2 {
        public static void Triple2(int origin, out int result) {
            result = origin * 3;
        }
    }
}
