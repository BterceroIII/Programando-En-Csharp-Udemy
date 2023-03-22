using System;

namespace Variables.Ejercicios
{
    /*
    En este problema vas a escribir varias operaciones binarias. Debajo del comentario, 
    pero encima del return, escribe lo siguiente:

    1) Súmale 10 a la variable numero (ya esta está declarada, no tienes que declararla)

    2) Mutiplícala por 2

    2) Luego réstale 3

    3) Súmale 29

    4) Divídela entre 2

    Nota: Lo puedes hacer en varias líneas para que tu código sea más claro.

    */
    public class OtrasOperacionesBinarias
    {
        public int Ejercicio(int numero){

            numero = numero + 10;
            numero = numero * 2;
            numero = numero - 3;
            numero = numero + 29;
            numero = numero / 2;
            return numero;
        }
    }
}
