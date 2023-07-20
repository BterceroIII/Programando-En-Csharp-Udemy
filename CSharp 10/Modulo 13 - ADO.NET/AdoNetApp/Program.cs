using AdoNetApp;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

//Variable de conexion
var conexionString = "Data Source=BTERCERO\\SQLEXPRESS;Database=AdoNet;Integrated Security=True;TrustServerCertificate=True";

//Estableciendo conexion
try
{
	using (SqlConnection conexion = new SqlConnection(conexionString))
	{
		//abrimos la conexion
		conexion.Open();
        Console.WriteLine("===========Conexion Abierta===========");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Conexion fallida");
    Console.WriteLine(ex.Message);
}
