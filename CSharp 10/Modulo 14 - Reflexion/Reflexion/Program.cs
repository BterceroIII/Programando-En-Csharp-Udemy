using Newtonsoft.Json;
using Reflexion;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Reflection;

// Ejemplo 1: instanciando una clase por el tipo

Type tipo = typeof(Producto);
var personasSinNombreViaType = (Producto)Activator.CreateInstance(tipo)!;

Console.WriteLine($"Productos instanciados por el type {personasSinNombreViaType}");

// Ejemplo 2: Intanciando una clase por su nombre y assembly

var nombreCompletoClaseProducto = typeof(Producto).FullName;
var assmblyClaseProducto = typeof(Producto).Assembly.GetName().Name;

var productoSinNombreString = (Producto)Activator.
    CreateInstance(assmblyClaseProducto, nombreCompletoClaseProducto)!.Unwrap()!;

Console.WriteLine($"Producto instanciada por un string {productoSinNombreString}");

// Ejemplo 3: Intanciando una clase pasandole valores al constructor

var productoConNombreType = (Persona)Activator.CreateInstance(typeof(Persona), 
    new object[] { "Byron Tercero" })!;

Console.WriteLine($"El nombre del producto es {productoConNombreType.Nombre}");
