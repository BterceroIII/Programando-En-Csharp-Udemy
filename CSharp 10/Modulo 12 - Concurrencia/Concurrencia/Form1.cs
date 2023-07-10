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
            //pictureBox1.Visible = true;

            int conteoColumnas = 1080;
            int conteoFilas = 1000;
            int conteoColumnas2 = 750;

            double[,] m1 = MatrizUtilidades.InicializarMatriz(conteoFilas, conteoColumnas);
            double[,] m2 = MatrizUtilidades.InicializarMatriz(conteoColumnas, conteoColumnas2);
            double[,] resultado = new double[conteoFilas, conteoColumnas2];

            Console.WriteLine("Ejecutando versi�n secuencial ...");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await Task.Run(() =>
            {
                MatrizUtilidades.MultiplicarMatricesSecuencial(m1, m2, resultado);
            });

            stopwatch.Stop();
            Console.WriteLine("Duraci�n en segundos de la versi�n secuencial: {0}",
                                    stopwatch.ElapsedMilliseconds / 1000.0);

            resultado = new double[conteoFilas, conteoColumnas2];

            Console.WriteLine("Ejecutando la versi�n en paralelo");
            stopwatch.Reset();
            stopwatch.Start();
            await Task.Run(() =>
            {
                MatrizUtilidades.MultiplicarMatricesParalelo(m1, m2, resultado);
            });

            stopwatch.Stop();
            Console.WriteLine("Duraci�n en segundos de la versi�n en paralelo: {0}",
                                    stopwatch.ElapsedMilliseconds / 1000.0);


            //pictureBox1.Visible = false;
        }



    }
}