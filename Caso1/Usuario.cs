using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    // Clase Producto
    public class Usuario
    {
        // Propiedades del usuario
        public string Nombre { get; private set; }
        public string Correo { get; private set; }
        public string Password { get; private set; }
        public string Rol { get; private set; }
        public string Telefono { get; private set; }
        public string Direccion { get; private set; }
        public bool EstadoActivo { get; private set; }

        // Constructor interno (solo el Builder puede crear el objeto)
        internal Usuario(string nombre, string correo, string password,
                         string rol, string telefono,
                         string direccion, bool estadoActivo)
        {
            Nombre = nombre;
            Correo = correo;
            Password = password;
            Rol = rol;
            Telefono = telefono;
            Direccion = direccion;
            EstadoActivo = estadoActivo;
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("=== Información del Usuario ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Rol: {Rol}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Activo: {EstadoActivo}");
        }
    }
}
