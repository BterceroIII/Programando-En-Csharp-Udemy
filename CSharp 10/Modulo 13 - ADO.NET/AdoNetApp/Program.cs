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


//Estableciendo conexion
try
{
	using (SqlConnection conexion = new SqlConnection(conexionString))
	{
		//abrimos la conexion
		conexion.Open();
        Console.WriteLine("===========Conexion Abierta===========");
        Console.WriteLine();
        var query = "Personas_Leer";

        using (SqlCommand comand = new SqlCommand(query, conexion))
        {
            comand.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adapter = new SqlDataAdapter(comand))
            {
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    Console.WriteLine($"{fila["IdPersona"]} | {fila["Nombre"]}");
                }
            }
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
