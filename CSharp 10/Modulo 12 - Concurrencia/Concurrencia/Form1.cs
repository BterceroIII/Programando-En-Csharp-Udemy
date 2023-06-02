using System.Diagnostics;

namespace Concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpClient httpClient = new HttpClient();

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            var directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            var destinoSecuencial = Path.Combine(directorioActual, @"Imagenes\resultado-secuencial");
            var destinoParalelo = Path.Combine(directorioActual, @"Imagenes\resultado-paralelo");

            PrepararEjecucion(destinoParalelo, destinoSecuencial);

            Console.WriteLine("Inicio");
            var imagenes = ObtenerImagenes();

            //parte secuencial
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (var imagen in imagenes)
            {
                await ProcesarImagen(destinoSecuencial, imagen);
            }

            Console.WriteLine($"Secuencial - duracion en segundos es {sw.ElapsedMilliseconds / 100.0}");

            sw.Restart();

            //parte en paralelo
            sw.Start();

            var tareasEnumerable = imagenes.Select(async imagen => {
                await ProcesarImagen(destinoParalelo, imagen);
            });

            await Task.WhenAll(tareasEnumerable);

            sw.Stop();

            Console.WriteLine($"Paralelo - duracion en segundos es {sw.ElapsedMilliseconds / 100.0}");
            pictureBox1.Visible = false;
        }

        private async Task ProcesarImagen(string directorio, Imagen imagen)
        {
            var respuesta = await httpClient.GetAsync(imagen.URL);
            var contenido = await respuesta.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(contenido))
            {
                bitmap = new Bitmap(ms);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destino = Path.Combine(directorio, imagen.Nombre);
            bitmap.Save(destino);
        }

        private void PrepararEjecucion(string destinoParalelo, string destinoSecuencial)
        {
            if (!Directory.Exists(destinoParalelo))
            {
                Directory.CreateDirectory(destinoParalelo);
            }

            if (!Directory.Exists(destinoSecuencial))
            {
                Directory.CreateDirectory(destinoSecuencial);
            }

            BorrarArchivos(destinoParalelo);
            BorrarArchivos(destinoSecuencial);
        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.EnumerateFiles(directorio);
            foreach (var archivo in archivos)
            {
                File.Delete(archivo);
            }
        }

        private List<Imagen> ObtenerImagenes()
        {
            var imagenes = new List<Imagen>();

            for (int i = 0; i < 7; i++)
            {
                imagenes.Add(new Imagen()
                {
                    Nombre = $"Perro loco {i}.jpg",
                    URL = "https://cdna.artstation.com/p/assets/images/images/046/235/272/smaller_square/pixel-arts-de-un-nino-random-ranita-uwu.jpg?1644605499"
                }) ;

                imagenes.Add(new Imagen()
                {
                    Nombre = $"Lucha {i}.jpg",
                    URL = "https://img.wattpad.com/2503f29daa545a3258af3d7c963b70e793cc0414/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f776174747061642d6d656469612d736572766963652f53746f7279496d6167652f442d36454a5f6c7a694f6e3877513d3d2d3138352e313631616131366239383036346363613334373336323038383137372e6a7067?s=fit&w=720&h=720"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"zospechoso {i}.jpg",
                    URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTyNGcjZpg5FYS5e8Hvd6KFjdNJs761B1q7UQ"
                });
            }

            return imagenes;
        }

    }
}