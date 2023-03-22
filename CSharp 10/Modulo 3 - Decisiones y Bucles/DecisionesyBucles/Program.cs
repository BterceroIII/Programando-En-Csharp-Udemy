
#region Tareas
//using DecisionesyBucles.Practica;

//_01_usuario obj = new _01_usuario();

//obj.Ejercicio1();
//obj.Ejercicio2();
//obj.Ejercicio3();
//obj.Ejercicio4();
//obj.Ejercicio5();
//obj.Ejercicio6();
//obj.Ejercicio7();
#endregion



//bucles infinitos

while (true)
{
    Console.WriteLine("Bienvenidos a la calculadora de C#");
    Console.Write("Ingrese un Numero: ");
    var entrada = Console.ReadLine();

    if (entrada is null)
    {
        Console.WriteLine("Error. Vuelve a intentarlo");
        continue;
    }

    var numero1 = decimal.Parse(entrada);

    Console.Write("Escriba el segundo Numero: ");
    entrada = Console.ReadLine();

    if (entrada is null)
    {
        Console.WriteLine("Error, vuelva a comenzar");
        continue;
    }

    var numero2 = decimal.Parse(entrada);

    Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es {numero1 + numero2}");
    Console.WriteLine("Deseas sumar otra ves? (y/n)");
    entrada = Console.ReadLine();

    if (entrada != "y")
    {
        break;
    }

}


Console.WriteLine("ADIOS!");