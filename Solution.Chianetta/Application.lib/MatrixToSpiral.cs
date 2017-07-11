using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.lib
{
    public static class MatrixToSpiral
    {
        public static readonly List<string> List = new List<string>();
        public static void Spiral(int[,] a, int colMin, int colMax, int rowMin, int rowMax)
        {
            
            if (colMax < colMin && rowMax < rowMin)
                return;

            int i = colMin, j = colMax, k = rowMin, l = rowMax;// COMMIT 04

            for (; i <= colMax; )
            {
                List.Add(a[k, i++].ToString());
            }

            for (--i, k++; k <= rowMax; )
            {
                List.Add(a[k++, i].ToString());
            }

            for (--k, --i; i >= colMin; )
            {
                List.Add(a[k, i--].ToString());
            }

            for (++i, --k; k > rowMin; )
            {
                List.Add(a[k--, i].ToString());
            }

            Spiral(a, ++colMin, --colMax, ++rowMin, --rowMax);
        }
    }
}
