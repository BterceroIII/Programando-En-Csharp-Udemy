// streams Writer
using Archivos;
using System.Text;

var ruta = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\personas.txt";


var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.99m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

// String Builder

var stringBuilder = new StringBuilder();

//foreach (var persona in personas)
//{
//    stringBuilder.AppendLine($"{persona.Nombre}|{persona.Salario}");
//}

//Posiciones de los caracteres
//foreach (var persona in personas)
//{
//    stringBuilder.AppendLine
//        ($"{persona.Id.ToString().PadLeft(10)}|{persona.Nombre.PadLeft(75)}|{persona.Salario.ToString().PadLeft(10)}");
//}


// modifica los espacios por '0' y hace un remplazo en el decimal
foreach (var persona in personas)
{
    var id = persona.Id.ToString().PadLeft(10, '0');
    var nombre = persona.Nombre.PadLeft(75);
    var salario = persona.Salario.ToString("N2").Replace(".", "").PadLeft(10, '0');

    stringBuilder.AppendLine($"{id}|{nombre}|{salario}");
}

using (var sw = new StreamWriter(ruta, append: false))
{
    sw.Write(stringBuilder.ToString());

}