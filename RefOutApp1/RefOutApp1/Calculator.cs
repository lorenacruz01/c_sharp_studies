using System;
using System.Collections.Generic;
using System.Text;

namespace RefOutApp1 {
    //utilizando o ref
    class Calculator {
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }

}
