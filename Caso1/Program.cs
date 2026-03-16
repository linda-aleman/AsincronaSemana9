using System;

namespace Caso1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construcción del usuario paso a paso
            Usuario usuario = new UsuarioBuilder()
                .SetNombre("Stiven Marquez")
                .SetCorreo("stivenmarquez@email.com")
                .SetPassword("123456")
                .SetRol("Administrador")
                .SetTelefono("78964537")
                .SetDireccion("Chalatenango")
                .SetEstadoActivo(true)
                .Build();

            usuario.MostrarInformacion();
        }
    }
}