using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.lib
{
    public static class EuleroProblem
    {
        public static int Eulero()
        {
            var numbers = Enumerable.Range(0, 1000)
                .Where(n => n%3 == 0 || n%5 == 0);

            return  numbers.Sum(); // COMMIT 03
            

        }
    }
}
