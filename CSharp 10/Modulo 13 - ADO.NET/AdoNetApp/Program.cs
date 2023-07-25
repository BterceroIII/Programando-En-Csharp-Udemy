using AdoNetApp;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Reflection.Metadata;

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
        var query = "Personas_Insertar";

        using (SqlCommand comand = new SqlCommand(query, conexion))
        {
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@nombre",nombre));
            var parametroId = new SqlParameter
            {
                ParameterName = "@id",
                Direction = ParameterDirection.Output,
                DbType = DbType.Int32,
            };

            comand.Parameters.Add(parametroId);

            var filasAfectadas = await comand.ExecuteNonQueryAsync();
            Console.WriteLine($"Filas afectadas: {filasAfectadas}");

            var id = (int)parametroId.Value;
            Console.WriteLine($"El ID de la persona es {id}");
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
