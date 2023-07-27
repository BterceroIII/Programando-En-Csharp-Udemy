using Newtonsoft.Json;
using Reflexion;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection;

//Ejemplo 1: Obteniendo un tipo base

var tipoBaseString = typeof(string).BaseType; 
var tipoBaseCarro = typeof(Carro).BaseType;

Console.WriteLine($"La clase base de string es {tipoBaseString}");
Console.WriteLine($"La clase base de carro es {tipoBaseCarro}");

//Ejemplo 2: Obteniendo las interfaces  de un tipo

Console.WriteLine("Las interfaces son: ");

foreach (var interfaz in typeof(string).GetInterfaces())
{
    Console.WriteLine($"- {interfaz}");
}

//Ejemplo 3: Viendo si un tipo hereda  de un interfaz o clase

var tipoString = typeof(string);
var tipoIEnumerable = typeof(IEnumerable);

Console.WriteLine($"String hereda de IEnumerable? R: {tipoString.IsAssignableTo(tipoIEnumerable)}");

Console.WriteLine($"Carro hereda de Vehiculo? R: {typeof(Carro).IsAssignableTo(typeof(Vehiculo))}");