using Reflexion;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var producto = new Producto();
producto.Modelo = 66;

var errores = validarObjeto(producto);

if (errores.Any())
{
    Console.WriteLine("El producto no tiene los datos correctos");

    foreach (var error in errores)
    {
        Console.WriteLine($"- Propiedad: {error.Propiedad}; Mensaje:" +
            $"{error.MensajeDeError}");
    }
}

IEnumerable<ErrorValidacion> validarObjeto( object obj)
{
    var t = obj.GetType();
    var propiedades = t.GetProperties();
    var resultado = new List<ErrorValidacion>();

    foreach (var propiedad in propiedades)
    {
        if (propiedad.IsDefined(typeof(RangeAttribute)))
        {
            var atributoRange = (RangeAttribute)Attribute
                .GetCustomAttribute(propiedad, typeof(RangeAttribute))!;
            var valor = (int)propiedad.GetValue(obj)!;
            var minimo = (int)atributoRange.Minimum;
            var maximo = (int)atributoRange.Maximum;
            var esValido = valor >= minimo && valor <= maximo;
            if (!esValido)
            {
                resultado.Add(new ErrorValidacion
                {
                    Propiedad = propiedad.Name,
                    MensajeDeError = $"El valor debe estar entre {minimo} y {maximo}"
                });
            }
        }

    }
        return resultado;
}