var rutaEjemplo = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos";

//Directory.CreateDirectory(ruta); // crea un directorio

// crea un enumerable de strings que contiene todas las carpetas del directorio
//var rutas = Directory.EnumerateDirectories(rutaEjemplo);
//var rutas = Directory.EnumerateDirectories(rutaEjemplo, "*", SearchOption.AllDirectories);

//var rutas = Directory.EnumerateFiles(rutaEjemplo, "*", SearchOption.AllDirectories);
var rutas = Directory.EnumerateFiles(rutaEjemplo, "*.json", SearchOption.AllDirectories);

foreach (var ruta in rutas)
{
    Console.WriteLine(ruta);
}

var rutaBorrar = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\Mi Directorio 2\sub directorio";


if (Directory.Exists(rutaBorrar))
{
    Directory.Delete(rutaBorrar);
    Console.WriteLine("Se ha borrado el directorio");
}
else
{
    Console.WriteLine("No se borro nada");
}
