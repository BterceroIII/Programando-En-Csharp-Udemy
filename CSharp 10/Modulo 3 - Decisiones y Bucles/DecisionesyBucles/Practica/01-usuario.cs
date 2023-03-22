using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Practica
{
    public class _01_usuario
    {
        public void Ejercicio1()
        {
            int numeroCliente = 0;

            Console.WriteLine("Ingrese un numero de cliente para ingresar");
            numeroCliente = Int32.Parse(Console.ReadLine());

            if (numeroCliente == 1000)
            {
                Console.WriteLine($"Bienvenido!");
            }
            else
            {
                Console.WriteLine($"Este {numeroCliente} es incorrecto, intentelo de nuevo");
            }
        }

        public void Ejercicio2()
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese un numero");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"El numero {numero2} es menor");
            }
            else
            {
                Console.WriteLine($"El numero {numero1} es menor");
            }

        }

        public void Ejercicio3()
        {
            string diaUsuario = "";

            Console.WriteLine("Diga un dia de la semana");
            diaUsuario = Console.ReadLine();

            if (diaUsuario == "Lunes" || diaUsuario == "Martes" )
            {
                Console.WriteLine($"Usted eligio  El lunes hasta martes");
            }
            else if (diaUsuario == "Miercoles" || diaUsuario == "Jueves")
            {
                Console.WriteLine($"Usted eligio  El Miercoles hasta el Jueves");
            }
            else if (diaUsuario == "Viernes" || diaUsuario == "Sabado")
            {
                Console.WriteLine($"Usted eligio  El Viernes hasta el Sabado");
            }
            else if (diaUsuario == "Domingo")
            {
                Console.WriteLine($"Usted eligio  El Domingo" );
            }
            else {
                Console.WriteLine($"Usted escribio el dia incorrecto");
            }
        }

       public void Ejercicio4()
        {
            int Numero = 0;
            int ValorAbsoluto = 0;

            Console.WriteLine("Escriba un numero");
            Numero = Int32.Parse(Console.ReadLine());

            if (Numero >= 0 )
            {
                ValorAbsoluto = Numero * 1;
            }
            else
            {
                ValorAbsoluto = Numero * -1;
            }

            Console.WriteLine($"Su valor absoluto es {ValorAbsoluto}");
        }

        public void Ejercicio5()
        {
            var nombre1 = "";
            var nombre2 = "";

            Console.WriteLine("Escribir el primer nombre");
            nombre1 = Console.ReadLine();

            Console.WriteLine("Escribir el segundo nombre");
            nombre2 = Console.ReadLine();

            if (nombre1[0] == nombre2[0] || nombre1[nombre1.Length -1] == nombre2[nombre2.Length-1])
            {
                Console.WriteLine("Coincidencia en los nombre");
            }
            else
            {
                Console.WriteLine("No tiene coincidencia");
            }
        }

        public void Ejercicio6()
        {
            var Candidato = "";

            Console.WriteLine("Elegir un Canditado de la A hasta C");
            Candidato = Console.ReadLine();

            if (Candidato.ToUpper() == "A" )
            {
                Console.WriteLine($"Ha votado por el canditado {Candidato.ToUpper()}");
            }
            else if (Candidato.ToUpper() == "B" )
            {
                Console.WriteLine($"Ha votado por el canditado {Candidato.ToUpper()}");
            }
            else if (Candidato.ToUpper() == "C" )
            {
                Console.WriteLine($"Ha votado por el canditado {Candidato.ToUpper()}");
            }
            else
            {
                Console.WriteLine("Canditado Incorrecto");
            }

        }

        public void Ejercicio7()
        {
            Console.WriteLine("Escribe solo una Letra");
            string letra = Console.ReadLine();
            

            if (letra.Length != 1)
            {
                Console.WriteLine("UNA LETRAAAAA!!");
            }
            else if(letra.Length == 1)
            {
                char letter = letra[0];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'  )
                {
                    Console.WriteLine("es una vocal");
                }
                else
                {
                    Console.WriteLine("No es vocal");
                }
            }
        }
    }
}
