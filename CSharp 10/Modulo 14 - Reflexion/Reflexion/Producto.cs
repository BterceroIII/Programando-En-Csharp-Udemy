using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string Nombre { get; set; }
        [Range(minimum: 5, maximum: 20)]
        public int Modelo { get; set; }
    }
}
