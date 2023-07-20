using AdoNetApp;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Utilizando proveedores de configuracion
using IHost host = Host.CreateDefaultBuilder(args).Build();

var configuration = host.Services.GetService<IConfiguration>();

//Variable de conexion
var conexionString = configuration.GetConnectionString("cadenaDeConexion");

Console.WriteLine("Escribe un nombre que quieres guardar: ");
var nombre = Console.ReadLine();

//Estableciendo conexion
try
{
	using (SqlConnection conexion = new SqlConnection(conexionString))
	{
		//abrimos la conexion
		conexion.Open();
        Console.WriteLine("===========Conexion Abierta===========");
        Console.WriteLine();
        var query = @"INSERT INTO Persona(Nombre)
                                    VALUES(@nombre)";

        using (SqlCommand comand = new SqlCommand(query, conexion))
        {
            comand.Parameters.Add(new SqlParameter("@nombre",nombre));
            var filasAfectadas = await comand.ExecuteNonQueryAsync();
            Console.WriteLine($"Filas afectadas: {filasAfectadas}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Conexion fallida");
    Console.WriteLine(ex.Message);
    if (ex.InnerException != null)
    {
        Console.WriteLine("Inner Exception:");
        Console.WriteLine(ex.InnerException.Message);
    }
}
