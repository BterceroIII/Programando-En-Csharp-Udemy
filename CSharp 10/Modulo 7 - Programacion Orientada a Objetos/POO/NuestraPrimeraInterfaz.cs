using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IMiInterfaz
    {
        void MiMetodo1();
        string MiMetodo2(int param1);
        bool MiPropiedad1 { get; set; }
        int MiPropiedadDeSoloLectura { get; }
    }

    internal interface SegundaInterface
    {
        void MetodoSegundaInterfasz();
    }

    internal class ClaseA : SegundaInterface
    {
        public void MetodoSegundaInterfasz()
        {
            Console.WriteLine("Implementacion de la clase A");
        }
    } 
    internal class ClaseB : SegundaInterface
    {
        public void MetodoSegundaInterfasz()
        {
            Console.WriteLine("Implementacion de la clase B");
        }
    }

    internal class MiClase : IMiInterfaz, SegundaInterface
    {
        public bool MiPropiedad1 { get; set; }

        public int MiPropiedadDeSoloLectura => 42;

        public void MetodoSegundaInterfasz()
        {

        }

        public void MiMetodo1()
        {
            
        }

        public string MiMetodo2(int param1)
        {
            return "Ejemplo";
        }
    }

    public record MiRecord(string param1) : SegundaInterface
    {
        public void MetodoSegundaInterfasz()
        {
            throw new NotImplementedException();
        }
    }

    public struct Mistruc : SegundaInterface
    {
        public void MetodoSegundaInterfasz()
        {
            throw new NotImplementedException();
        }
    }
}
