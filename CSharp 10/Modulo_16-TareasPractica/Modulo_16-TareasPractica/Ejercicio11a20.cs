using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_16_TareasPractica
{
    public class Ejercicio11a20
    {
        void Ejericio11()
        {
            // suma y multiplicacion de positivos y negativos
            decimal num = 0, may0 = 0, men0 = 1, x = 0;
            for (int count = 0; count < 10; count++)
            {
                do
                {
                    Console.WriteLine($"Numero: ");
                    num = decimal.Parse(Console.ReadLine());
                } while (num == 0);

                if (num > 0)
                {
                    may0 = may0 + num;
                }
                else if (num < 0)
                {
                    men0 = men0 * num;
                }

                if (men0 == 1)
                {
                    men0 = 0;
                }

            }


            Console.WriteLine($"La suma de los numero + es {may0} y el producto de los - es {men0}");
        }

        void Ejericio12()
        {
            int numero1 = 0, numero2 = 0, aux1 = 0;

            Console.WriteLine("Ingrese un numero par intercambiar: ");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero par intercambiar: ");
            numero2 = Int32.Parse(Console.ReadLine());

            aux1 = numero1;
            numero1 = numero2;
            numero2 = aux1;

            Console.WriteLine($"El primer numero 1 ahora es {numero1} y el numero 2 es {numero2}");
        }

        void Ejercio13()
        {
            int numero = 0;

            Console.WriteLine("Ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());

            int cuadrado = (int)Math.Pow(numero, 2);
            int cubo = (int)Math.Pow(numero, 3);

            Console.WriteLine($"El cuadrado es {cuadrado} y el cubo es {cubo}");
        }

        void Ejercicio14()
        {
            Console.WriteLine("Cuanto peso desea registar?");
            int cantidad = Int32.Parse(Console.ReadLine());
            int contadorMas = 0;
            int contadorMenos = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el peso");
                int peso = Int32.Parse(Console.ReadLine());

                if (peso > 80)
                {
                    contadorMas++;
                }
                else
                {
                    contadorMenos++;
                }
            }

            Console.WriteLine($"La cantidad de peso mas de 80 es {contadorMas} y la cantidad menor a 80 es {contadorMenos}");
        }

        void Ejercio15()
        {
            //Mostrar que triangulo es
            float[] lado = new float[3];
            float mayor = 0, sumar = 0;
            int aux = 0, flag = 0, i, j;


            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"Lado {i + 1}: ");
                lado[i] = float.Parse(Console.ReadLine());

                if (lado[i] > mayor)
                {
                    mayor = lado[i];
                    aux = i;
                }
            }

            for (i = 0; i < 3; i++)
            {
                if (aux != i)
                {
                    sumar += lado[i];
                }
            }

            if (mayor < sumar)
            {
                Console.Write("Es un triangulo");

                for (i = 0; i < 2; i++)
                {
                    for (j = i + 1; j < 3; j++)
                    {
                        if (lado[i] == lado[j])
                        {
                            flag++;
                        }
                    }
                }
                if (flag == 3)
                {
                    Console.Write("---->equilatero");
                }
                else
                {
                    flag = 0;
                    for (i = 0; i < 2; i++)
                    {
                        for (j = i + 1; j < 3; j++)
                        {
                            if (lado[i] != lado[j])
                            {
                                flag++;
                            }
                        }
                    }
                }
                if (flag == 3)
                {
                    Console.Write("----> Escaleno");
                }
                else
                {
                    Console.Write("----> Isoceles");
                }
            }
            else
            {
                Console.Write("No es un triangulo");
            }

        }
    }
}
