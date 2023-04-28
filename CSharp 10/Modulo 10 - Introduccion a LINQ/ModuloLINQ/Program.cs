using ModuloLINQ;

int[] numeros = Enumerable.Range(1,10).ToArray();

//metodo Where 
var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();
var numerosImpares2 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

// Ejemplo 2 con lista de objetos

var personas = new List<Persona>
{
    new Persona {Nombre = "Byron Tercero", Edad = 20, Soltero = true, EmpresaId = 1, FechaIngresoALaEmpresa = DateTime.Now},
    new Persona {Nombre = "Jose Cruz", Edad = 25, Soltero = true, EmpresaId = 2, FechaIngresoALaEmpresa = DateTime.Now},
    new Persona {Nombre = "Gabriela Rocha", Edad = 27, Soltero = false, EmpresaId = 3, FechaIngresoALaEmpresa = new DateTime(2022, 4, 12)},
    new Persona {Nombre = "Rodolfo Alto", Edad = 23, Soltero = true, EmpresaId = 4, FechaIngresoALaEmpresa = new DateTime(2022, 6, 11)}
};

var Personas25AniosOMenos = personas.Where(n => n.Edad <= 25).ToList();

foreach (var persona in Personas25AniosOMenos)
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} anios");
}

Console.WriteLine();
var solteros = personas.Where(p => p.Soltero == true).ToList();

foreach (var soltero in solteros)
{
    Console.WriteLine($"Los solteros son {soltero.Nombre}");
}

Console.WriteLine();

var solterosMenoresA25 = personas.Where(p => p.Soltero && p.Edad <= 25).ToList();

foreach (var solteroMenor in solterosMenoresA25)
{
    Console.WriteLine($"Solteros menores de 25 son {solteroMenor.Nombre} con {solteroMenor.Edad} anios");
}

Console.WriteLine();

var fechaActual = DateTime.Today;
var personasConMenosDe3MesesEnLaEmpresa = personas.Where(p => p.FechaIngresoALaEmpresa >= 
                                                        fechaActual.AddMonths(-3)).ToList();

foreach (var personasMeses in personasConMenosDe3MesesEnLaEmpresa)
{
    Console.WriteLine($"Las personas que llevan menos de 3 meses son {personasMeses.Nombre} con {personasMeses.FechaIngresoALaEmpresa}");
}