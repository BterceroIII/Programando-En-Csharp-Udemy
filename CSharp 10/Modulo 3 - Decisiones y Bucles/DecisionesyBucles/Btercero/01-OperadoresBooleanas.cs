using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _01_OperadoresBooleanas
    {
        public void Anotaciones()
        {
            var cantidad1 = 11;
            var cantidad2 = 10;

            var igualdad = cantidad1 == cantidad2; // true

            var diferencia = cantidad1 != cantidad2; // false

            Console.WriteLine($"Es {cantidad1} y {cantidad2} iguales? {igualdad}");
            Console.WriteLine($"Es {cantidad1} y {cantidad2} son diferentes? {diferencia}");


            var menor = cantidad1 < 10; // true
            var mayor = cantidad2 > 10; // false

            Console.WriteLine($"es {cantidad1} menor que 10? {menor}");
            Console.WriteLine($"es {cantidad1} mayor que 10? {mayor}");

            var menorIgual = cantidad1 <= 10; // true
            var mayorIgual = cantidad2 <= 10; // true

            Console.WriteLine($"es {cantidad1} menor o igual que 10? {menorIgual}");
            Console.WriteLine($"es {cantidad2} mayor o igual que 10? {mayorIgual}");

            var nombre1 = "Felipe";
            var nombre2 = "Juan";

            var nombresIguales = nombre1 == nombre2; // false

            var nombreNull = nombre1 is null; // false

            Console.WriteLine($"es {nombre1} igual que {nombre2}? {nombresIguales}");
            Console.WriteLine($"es {nombre1} es null? {nombreNull}");
        }
    }
}
