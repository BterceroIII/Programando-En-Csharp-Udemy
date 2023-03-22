using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_16_TareasPractica.Ejercicios
{
    public class Ejercicios2a10
    {
        void Ejercicio2()
        {
            // ejercicio 2
            int impar = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Numero impar: {i}");

                }
            }
        }

        void Ejericios3()
        {
            //ejercicio 3 impresion de numeros pares
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Numeros pares: {i}");
                }
            }
        }

        void Ejercicio4()
        {
            // Mostrar del 0 al 100
            for (int i = 0; i < 100 + 1; i++)
            {
                Console.WriteLine($"Numero #{i}");
            }
        }

        void Ejercicio5()
        {
            // mostrar del 100 a 0
            for (int i = 100; i > 0 -1; i--)
            {
                Console.WriteLine($"Numero #{i}");
            }
        }

        void Ejericio6()
        {
            //multiplos de 3
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Multiplos de 3 son : {i}");
                }
            }
        }

        void Ejercicio7()
        {
            // multiplos de 3 y 2
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 2 == 0)
                {
                    Console.WriteLine($"Numeros de multiplos de 3 y 2: {i}");
                }
            }
        }

        void Ejercio8()
        {
            // suma de un numero que lo antedecen

            Console.WriteLine("Ingrese un numero");
            int numero = Int32.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < numero; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine($"La suma de los nuemeros es: {numero} {suma}");

        }

        void Ejercicio9()
        {

            // ingresar y mostrar n cantida de multiplos de 3
            Console.WriteLine("Ingresa un numero limite");
            int count = Int32.Parse(Console.ReadLine());
            int cont = 0, n;

            for (int i = 0; i < count + 1; i++)
            {
                if (i % 3 == 0)
                {
                    cont++;
                }

            }
            Console.WriteLine($"Entre el 1 y el {count} hay {cont} multiplos de 3");
        }

        void Ejercicio10() {
            // numeros primos del 1 hasta el 100
            int contador = 0;

            for (int n = 1; n <= 100; n++)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine($"{n}");
                }

                contador = 0;
            }
        }

        

    }
}
