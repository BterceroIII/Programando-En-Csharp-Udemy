var ruta = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\ejemplo.txt";

var rutaDestino = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\ejemplo copiado.txt";

if (File.Exists(ruta))
{
    var contenido = File.ReadAllText(ruta); // lee el archivo
    Console.WriteLine(contenido);
    // copia el archivo y lo sobre escribe
    File.Copy(ruta, rutaDestino, overwrite: true);
}
else
{
    Console.WriteLine("No existe el archivo");
}

// elemina el archivo destino
File.Delete(rutaDestino);

Console.WriteLine();