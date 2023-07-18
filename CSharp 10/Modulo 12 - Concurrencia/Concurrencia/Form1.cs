using System.Diagnostics;

namespace Concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private  void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio");

            var valorSinInterlock = 0;

            Parallel.For(0, 1000000, numero => valorSinInterlock++);

            Console.WriteLine($"La sumatoria es de {valorSinInterlock}");

            var valorConInterlock = 0;

            Parallel.For(0, 1000000, numero => Interlocked.Increment(ref valorConInterlock));

            Console.WriteLine($"La sumatoria es de {valorConInterlock}");
        }



    }
}