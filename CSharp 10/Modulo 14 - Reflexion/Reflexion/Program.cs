using Newtonsoft.Json;
using Reflexion;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection;

//Ejemplo 1: invocando un metodo void sin parametros

var tipo = typeof(Utilidades);
var utilidades = Activator.CreateInstance(tipo);


tipo.InvokeMember("ImprimirHoraActual", BindingFlags.InvokeMethod,
     binder: null, target: utilidades, args: new object[] { });

//Ejemplo 2: Invocando un metodo void con parametros

tipo.InvokeMember("ImprimirMensaje", BindingFlags.InvokeMethod,
     binder: null, target: utilidades, args: new object[] { "Uso del metodo" });

//Ejemplo 3: Invocnado un metodo que devuelve un valor

var resultado = tipo.InvokeMember("ObteniendoUnValor", BindingFlags.InvokeMethod,
    binder: null, target: utilidades, args: new object[] { });

Console.WriteLine($"El resultado del metodo es: {resultado}");

//Ejemplo 4: Invocando un metodo estatico

tipo.InvokeMember("MetodoEstatico", BindingFlags.InvokeMethod,
    binder: null, target: null, args: new object[] { });

//Ejemplo 5: Invocando un metodo etatico void privado

tipo.InvokeMember("MetodoPrivado", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,
    binder: null, target: utilidades, args: new object[] { });