using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileEjer1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0,
            suma = 0,
            r = 0;
            do 
            {
                Console.WriteLine(x);
                x++;
                //if (x == 5)  //en estas dos lineas se ejecuta eun brake cuando llegue al numero indicado en el if (x == 5)
                  //  break;
            } while (x <100);
            r = suma + x;
            {
                Console.WriteLine(r);     
            }
            Console.ReadKey();  

        }
    }
}
