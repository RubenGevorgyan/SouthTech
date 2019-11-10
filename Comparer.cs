using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SouthTech
{
    static class TComparer
    {
        public static int Compare(string x, string y)
        {
            float xint = float.MinValue;
            float yint = float.MinValue;

            if (float.TryParse(x, out xint) && float.TryParse(y, out yint))
            {
                if (xint > yint) return 1;
                if (xint < yint) return -1;
                else return 0;
            }
            else
            {
                return String.Compare(x, y);
            }
        }
    }
}
