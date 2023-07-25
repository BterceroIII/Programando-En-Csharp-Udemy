using Newtonsoft.Json;
using Reflexion;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Reflection;

// Crear una variable de tipo Type
Type tipo = typeof(int);

// a partir de un entero creo una variable Type
int edad = 99;
Type tipoDatoEdad = edad.GetType();

// crear variable type con un string
Type tipoDatoString = Type.GetType("System.Int32")!;
//uso de propiedades de Type Name y Type IsArray dara un resultado boleano
Console.WriteLine($"Es {tipoDatoString.Name} un Array? {tipoDatoString.IsArray}");