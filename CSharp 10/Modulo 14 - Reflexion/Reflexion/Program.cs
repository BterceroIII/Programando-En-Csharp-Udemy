using Newtonsoft.Json;
using Reflexion;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection;

var producto = new Producto();

producto.Modelo = 1;

var esValido = ValidarProducto(producto);

if (!esValido)
{
    Console.WriteLine("No tiene un modelo correcto");
    return;
}

Console.WriteLine($"El modelo del producto es: {producto.Modelo}");


bool ValidarProducto (Producto p)
{
    var tipo = p.GetType();

    var propiedadModelo = tipo.GetProperty("Modelo");

    if (propiedadModelo.IsDefined(typeof(RangeAttribute)))
    {
        var atributoRange = (RangeAttribute)Attribute.GetCustomAttribute(propiedadModelo, typeof(RangeAttribute))!;

        return p.Modelo >= (int)atributoRange.Minimum && p.Modelo <= (int)atributoRange.Maximum;
    }

    return true;
}