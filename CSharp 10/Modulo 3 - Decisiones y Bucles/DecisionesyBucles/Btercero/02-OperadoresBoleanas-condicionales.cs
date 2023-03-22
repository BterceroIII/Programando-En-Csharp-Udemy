using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _02_OperadoresBoleanas_condicionales
    {
        public void Anotaciones()
        {
            var cantidad1 = 6;

            var distanciaEntre = cantidad1 > 5 && cantidad1 < 10; // true

            Console.WriteLine($"esta el {cantidad1} entre 5 y 10? {distanciaEntre}");

            var cantidadEs5o6 = cantidad1 == 5 || cantidad1 == 6; //true

            Console.WriteLine($"es {cantidad1} igual a 5 0 6? {cantidadEs5o6}");


            // ejemplo de referencia nula

            string apellido = null;

            var mayuscula = apellido is not null && apellido == apellido.ToUpper();

            Console.WriteLine($"Esta en mayuscula el string? {mayuscula}");
        }
    }
}
