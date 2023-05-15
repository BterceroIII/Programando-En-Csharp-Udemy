var rutaEjemplo = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\";

var rutas = Directory.EnumerateDirectories(rutaEjemplo, "*", SearchOption.AllDirectories);

foreach (var ruta in rutas)
{
    var nombreArchivo = Path.GetFileName(ruta); // obtiene la nombre de la ruta
    var extension = Path.GetExtension(ruta); // obtiene la extension  de los archivos
    Console.WriteLine($"{nombreArchivo} - extension: {extension}");
}

//combinar rutas

var ruta1 = @"C:\user\source";
var ruta2 = @"repos\archivos";

var rutasCombinadas = Path.Combine(ruta1, ruta2);
Console.WriteLine(rutasCombinadas);