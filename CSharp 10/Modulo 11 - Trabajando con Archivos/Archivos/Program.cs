// streams Writer
using Archivos;
using System.Text;

var ruta = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\personas.csv";


var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.99m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

// crear un CSV

var stringBuilder =  new StringBuilder();

foreach (var persona in personas)
{
    stringBuilder.AppendLine($"{persona.Id},{persona.Nombre},{persona.Salario}");
}

using (var sw = new StreamWriter(ruta, append: false, Encoding.UTF8))
{
    sw.WriteLine(stringBuilder.ToString());
}