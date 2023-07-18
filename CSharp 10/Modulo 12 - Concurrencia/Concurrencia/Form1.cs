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
            var valorConInterlocked = 0;
            var valorConInterlocked2 = 0;

            Parallel.For(0, 10_000, numero =>
            {
                Interlocked.Increment(ref valorConInterlocked);
                Interlocked.Add(ref valorConInterlocked2, valorConInterlocked);
            });

            Console.WriteLine($"Valor incrementado {valorConInterlocked}");
            Console.WriteLine($"Valor sumado {valorConInterlocked2}");

            Console.WriteLine($"=====================================");
            var valorIncrementado = 0;
            var valorSumado = 0;

            var mutex = new object();

            Parallel.For(0, 10_000, numero =>
            {
                lock (mutex)
                {
                    valorIncrementado++;
                    valorSumado += valorIncrementado;
                }
            });

            Console.WriteLine($"Valor incrementado con Lock {valorIncrementado}");
            Console.WriteLine($"Valor Sumado con Lock {valorSumado}");
            Console.WriteLine($"=====================================");
        }



    }
}