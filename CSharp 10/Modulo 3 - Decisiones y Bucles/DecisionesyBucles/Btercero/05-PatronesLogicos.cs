using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _05_PatronesLogicos
    {
        void Anotaciones()
        {
            //Ejemplo 1: Not

            //string? apellido = "Gavilan";

            //    if (apellido is not null)
            //    {
            //        Console.WriteLine(apellido.ToUpper());
            //    }

            //    Console.WriteLine("Fin");

            //Ejemplo 2 : And

            //var temperatura = 38;

            //var mensaje = temperatura switch
            //{
            //    37 => "No tienes ninguna condicion",
            //    > 37 and < 39 => "Tienes fiebre",
            //    >= 39 and < 43 => "Debes ir al medico",
            //    >= 43 => "omae wa mou shindeiru",
            //};

            //Console.WriteLine(mensaje);

            //Ejemplo 3 : Or

            var hoy = DateTime.Today;

            var estacion = hoy.Month switch
            {
                3 or 4 or 5 => "Primavera",
                6 or 7 or 8 => "Verano",
                9 or 10 or 11 => "Otonio",
                12 or 1 or 2 => "Invierno",
                _ => throw new ApplicationException("Mes incorrecto")
            };

            Console.WriteLine(estacion);
        }
    }
}
