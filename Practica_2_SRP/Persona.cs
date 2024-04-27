using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_SRP
{
    public class Persona
    {
        private String nombre;
        private int edad;
        private String direccion;
        private String correoElectronico;

        public Persona(String nombre, int edad, String direccion, String correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public void mostrarInfoPersona()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " +  edad);
            Console.WriteLine("Direccion: " +  direccion);
            Console.WriteLine("Correo Electronico: " +  correoElectronico);
        }
    }
}
