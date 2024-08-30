using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MethodeExtension
{
    internal static class MethodeExtension
    {

        public static string AddUpperAndPoint(this string source)
        {
            string result = "";
            for (int i = 0; i < source.Length; i++)
            {
                result += source[i];
                if (i == 0) result = result.ToUpper();
                if (i == source.Length - 1 && source[i] != '.' && source[i] != '!' && source[i] != '?')
                    result += '.';
            }
            return result;
        }
        public static int Multiple2(this int source)
        {
            return source * 2;
        }
    }
}
