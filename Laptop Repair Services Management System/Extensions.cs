using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laptop_Repair_Services_Management_System
{
    public static class Extensions
    {
        public static string Filter(this string str, List<char> charToRemove)
        {
            String chars = "[" + String.Concat(charToRemove) + "]";
            return Regex.Replace(str, chars, String.Empty);
        }
    }
}
