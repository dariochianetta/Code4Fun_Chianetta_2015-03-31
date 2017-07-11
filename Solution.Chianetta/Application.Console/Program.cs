using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.lib;

namespace Application.Chianetta
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("La somma dei multipli è: {0}",  EuleroProblem.Eulero());//TODO tets
            Console.ReadLine();
           
            int[,] a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };

            MatrixToSpiral.Spiral(a,0,3,0,4);
            MatrixToSpiral.List.ForEach(i => Console.Write(" {0} ", i));
            Console.ReadKey();
        }
    }
}
