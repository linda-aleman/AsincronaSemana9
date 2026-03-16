using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    // Clase Builder
    public class UsuarioBuilder
    {
        private string _nombre;
        private string _correo;
        private string _password;
        private string _rol;
        private string _telefono;
        private string _direccion;
        private bool _estadoActivo;

        // Métodos para construir paso a paso

        public UsuarioBuilder SetNombre(string nombre)
        {
            _nombre = nombre;
            return this;
        }

        public UsuarioBuilder SetCorreo(string correo)
        {
            _correo = correo;
            return this;
        }

        public UsuarioBuilder SetPassword(string password)
        {
            _password = password;
            return this;
        }

        public UsuarioBuilder SetRol(string rol)
        {
            _rol = rol;
            return this;
        }

        public UsuarioBuilder SetTelefono(string telefono)
        {
            _telefono = telefono;
            return this;
        }

        public UsuarioBuilder SetDireccion(string direccion)
        {
            _direccion = direccion;
            return this;
        }

        public UsuarioBuilder SetEstadoActivo(bool estado)
        {
            _estadoActivo = estado;
            return this;
        }

        // Método que construye el objeto final
        public Usuario Build()
        {
            return new Usuario(_nombre, _correo, _password, _rol,
                               _telefono, _direccion, _estadoActivo);
        }
    }
}
