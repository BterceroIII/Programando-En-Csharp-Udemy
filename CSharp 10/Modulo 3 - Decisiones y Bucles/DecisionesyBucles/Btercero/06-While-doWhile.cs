using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _06_While
    {
        void Anotaciones()
        {
            //int contador = 1;

            //while (contador <= 100)
            //{
            //    Console.WriteLine(contador);
            //    contador++;
            //}

            var balance = 200m;
            var interes = 1.07m;
            var contador = 1;

            while (contador <= 10)
            {
                balance *= interes;
                contador++;
            }

            Console.WriteLine(balance);
        }

        void Anotaciones1()
        {
            var contador = 1;
            do
            {
                Console.WriteLine(contador);
                   contador++;
            } while (contador > 10);
        }
    }
}
