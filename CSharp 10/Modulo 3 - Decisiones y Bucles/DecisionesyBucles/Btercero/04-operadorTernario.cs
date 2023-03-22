using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Btercero
{
    internal class _04_operadorTernario
    {
        public void Anotaciones()
        {
            bool usuarioLogueado = true;

            //string mensaje;

            //if (usuarioLogueado)
            //{
            //    mensaje = "Has vuelto!";
            //}
            //else
            //{
            //    mensaje = "Logueate para comenzar";
            //}

            //Console.WriteLine(mensaje);

            string mensaje = usuarioLogueado ? "Has vuelto" : "Logueate para comenzar";

            Console.WriteLine(mensaje);
        }
    }
}
