using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_16_TareasPractica.Ejercicios
{
    internal class _01
    {
        void ObtenerNotasAlumnos()
        {
            Console.WriteLine("Ingresa la cantidad de alumnos a registrar: ");
            int alumnosCount = Int32.Parse(Console.ReadLine());
            decimal[,] arregloCalificaciones = new decimal[alumnosCount, 2];
            Console.WriteLine();


            // recorer los alumnos para solicitar su calificacion

            for (int i = 0; i <= alumnosCount - 1; i++)
            {
                Console.WriteLine($"Calificacion del alumno #{(i + 1).ToString()}");
                arregloCalificaciones[i, 0] = Convert.ToDecimal(Console.ReadLine());//calificaciones
                arregloCalificaciones[i, 1] = (i + 1);//alumno
                Console.WriteLine();
            }

            // obtener alumno con el mejor promedio

            decimal calificacion = 0;
            decimal alumno = 0;
            for (int i = 0; i <= alumnosCount - 1; i++)
            {
                if (arregloCalificaciones[i, 0] > calificacion)
                {
                    calificacion = arregloCalificaciones[i, 0];
                    alumno = arregloCalificaciones[i, 0] = (i + 1);
                }
            }

            Console.WriteLine("El mejor promedio es el alumno #{0} con una calificacion de: {1}", alumno.ToString(),
                   calificacion.ToString());
            Console.WriteLine();

            // obtener alumno con el mejor promedio

            calificacion = 10;
            alumno = 0;
            for (int i = 0; i <= alumnosCount - 1; i++)
            {
                if (arregloCalificaciones[i, 0] < calificacion)
                {
                    calificacion = arregloCalificaciones[i, 0];
                    alumno = arregloCalificaciones[i, 0] = (i + 1);
                }
            }

            Console.WriteLine("El peor promedio es el alumno #{0} con una calificacion de: {1}", alumno.ToString(),
                   calificacion.ToString());
            Console.WriteLine();

        }
    }
}
