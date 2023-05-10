using ModuloLINQ;
using System.ComponentModel.DataAnnotations.Schema;

var personas = new List<Persona>
{
    new Persona {Nombre = "Byron Tercero", Edad = 20, Soltero = true, EmpresaId = 1, FechaIngresoALaEmpresa = DateTime.Now},
    new Persona {Nombre = "Jose Cruz", Edad = 25, Soltero = true, EmpresaId = 2, FechaIngresoALaEmpresa = DateTime.Now},
    new Persona {Nombre = "Gabriela Rocha", Edad = 27, Soltero = false, EmpresaId = 3, FechaIngresoALaEmpresa = new DateTime(2022, 4, 12)},
    new Persona {Nombre = "Rodolfo Alto", Edad = 23, Soltero = true, EmpresaId = 4, FechaIngresoALaEmpresa = new DateTime(2022, 6, 11)}
};

//foreach (var persona in personas.OrderBy(p => p.Edad))
//{
//    Console.WriteLine($"{persona.Nombre} tiene una edad de {persona.Edad}");
//}

// ejemplo 2

int[] numeros = { 1, 4, 5, 7, 2, 3, 8, 10, 9 };

var numerosOrdenados = numeros.OrderBy(n => n).ToList();

foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}