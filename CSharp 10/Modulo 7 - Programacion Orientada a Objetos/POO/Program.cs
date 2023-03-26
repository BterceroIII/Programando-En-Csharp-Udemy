// El código de los videos puede ser encontrado en la carpeta 'Codigo'

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POO;

var hostbuilder = Host.CreateDefaultBuilder(args);
hostbuilder = hostbuilder.ConfigureServices(ConfigurarServicios);
using var host = hostbuilder.Build();


var controladorDePeliculas = host.Services.GetRequiredService<ControladorDePeliculas>();
var otroLugar = host.Services.GetRequiredService<OtroLugar>();

controladorDePeliculas.GuardarPoster("Poster.jpg");
controladorDePeliculas.BorrarPoster("Poster.jpg");
otroLugar.Procesar();

void ConfigurarServicios(IServiceCollection services)
{
    services.AddTransient<IAlmacenadorArchivos, AlmacenadorArchivosAzure>();
    services.AddTransient<ControladorDePeliculas>();
    services.AddTransient<OtroLugar>();
}

