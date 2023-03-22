using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Implementa una función, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor máximo de dicho arreglo, 
    el valor mínimo, y el valor promedio.

    Para este ejercicio, utilizaremos parámetros out para extraer los tres valores.

    La función devolverá true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolverá false.

    El orden de los parámetros es: int[] numeros, int minimo, int maximo, double promedio

    Nota: debes de colocar out en los parámetros adecuados.
     */

    public class MinMaxPromedio
    {
        bool ObtenerMinMaxPromedio(int[] numeros, out int minimo, out int maximo, out double promedio)
        {
            minimo = 0;
            maximo = 0;
            promedio = 0.0;

            if (numeros.Length == 0)
            {
                return false;
            }

            maximo = numeros[0];
            minimo = numeros[0];
            var suma = 0.0;

            foreach (var numero in numeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }

                suma += numero;
            }

            promedio = suma / numeros.Length;

            return true;
        }
    }
}
