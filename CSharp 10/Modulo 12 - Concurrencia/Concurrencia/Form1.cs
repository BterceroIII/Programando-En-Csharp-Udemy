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

        private  void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Numeros hasta el 10");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("EN PARALELO");
            Parallel.For(1, 11, i => Console.WriteLine(i));
        }

      

    }
}