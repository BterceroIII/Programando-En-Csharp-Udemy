using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _03_Sentencia_If
    {
        public void Anotaciones()
        {
            var cantidad1 = 10;

            if (cantidad1 > 5)
            {
                Console.WriteLine($"Es mayor que 5");
            }
            else if (cantidad1 == 3)
            {
                Console.WriteLine($"la cantidad es 3");
            }
            else
            {
                Console.WriteLine($"Es menor o igual que 5");
            }

            Console.WriteLine($"Fin");
        }
    }
}
