using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaVI
{
    public static class Helper
    {

        public static List<int> Pares(this List<int> num)
        {
            return num.FindAll(r => (r % 2) == 0);
        }
    }
}
