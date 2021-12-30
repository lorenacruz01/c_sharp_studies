using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsApp1.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if(thisObj.Length <= 10)
            {
                return thisObj;
            } else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
