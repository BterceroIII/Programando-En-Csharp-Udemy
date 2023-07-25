using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class Producto
    {
        public Producto() 
        { 
        
        }

        public Producto(string nombre)
        {
            Nombre = nombre;
        }

        string Nombre { get; set; }
    }
}
