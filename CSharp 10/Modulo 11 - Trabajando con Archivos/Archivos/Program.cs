// streams Writer
var ruta = @"F:\Documentos\REPOSITORIOS\.NET\Curso_CSharp\Programando-En-Csharp-Udemy\CSharp 10\Modulo 11 - Trabajando con Archivos\Archivos\mensaje.txt";


// using como alternativa com dispose
using (var streamWriter = new StreamWriter(ruta, append: true)) 
{
    streamWriter.WriteLine("Buenos dias");
    streamWriter.Write("En esta carta");
    streamWriter.WriteLine($"te informo que la hora es {DateTime.Now.ToString("hh:mm:ss")}");
    streamWriter.Write("bye");

}// append se va indexar abajo del archivo



