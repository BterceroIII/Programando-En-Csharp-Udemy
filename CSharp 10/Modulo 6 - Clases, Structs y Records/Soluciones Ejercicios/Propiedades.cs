using System;

namespace Coding.Exercise
{
    // Aquí puedes crear la clase (Nota: colocala como public)
    
    public class Persona{
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
    
    public class Ejercicio
    {
        public Persona ConstruirPersona (string nombre, string apellido, DateTime fechaNacimiento)
        {
            var persona = new Persona();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.FechaNacimiento = fechaNacimiento;
            return persona;
        }
    }
}
