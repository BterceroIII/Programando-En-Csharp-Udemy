using Reflexion;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

// Atributos personalizados

Console.WriteLine($"--Puedes realizar las siguientes acciones--");

foreach (var accion in Enum.GetValues<Acciones>())
{
    var campo = typeof(Acciones).GetField(accion.ToString());
    var esconderAtributo = campo.GetCustomAttribute(typeof(EsconderAttribute));

    if (esconderAtributo is not null)
    {
        var esconder = ((EsconderAttribute)esconderAtributo).Ocultar();

        if (esconder)
        {
            continue;
        }
    }

    Console.WriteLine(accion);
}