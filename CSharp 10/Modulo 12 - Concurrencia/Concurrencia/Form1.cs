using System.Diagnostics;

namespace Concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            var sw = new Stopwatch();

            sw.Start();

            // esto hace los procesos uno por uno
            //await RealizarProcesoLargoA();
            //await RealizarProcesoLargoB();
            //await RealizarProcesoLargoC();

            // aqui hace los procesos al mismo tiempo
            var tareas = new List<Task>()
            {
                 RealizarProcesoLargoA(),
                 RealizarProcesoLargoB(),
                 RealizarProcesoLargoC()
            };
            // WhenAll procesa las tareas al mismo tiempo
            await Task.WhenAll(tareas);

            sw.Stop();

            var duracion = $"El programa se ejecuto en {sw.ElapsedMilliseconds / 100.0} segundos";
            Console.Write(duracion);
            pictureBox1.Visible = false;
        }

        private async Task RealizarProcesoLargoA()
        {
            await Task.Delay(500);
            Console.WriteLine("Proceso A finalizado");
        }

        private async Task RealizarProcesoLargoB()
        {
            await Task.Delay(500);
            Console.WriteLine("Proceso B finalizado");
        }

        private async Task RealizarProcesoLargoC()
        {
            await Task.Delay(500);
            Console.WriteLine("Proceso C finalizado");
        }

    }
}