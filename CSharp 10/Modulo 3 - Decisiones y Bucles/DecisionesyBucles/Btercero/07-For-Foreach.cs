using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _07_For_Foreach
    {
        void Anotaciones()
        {
            // sintaxis
            //for (int contador = 1; contador <= 10; contador++)
            //{
            //    Console.WriteLine("Hola su numero es " + contador);
            //}


            // Foreach sintaxis

            var nombre = "Byron";

            foreach (var letra in nombre)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
