using System;

namespace Caso2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporte reporte = new ReporteBuilder()
                .SetTitulo("Reporte de Ventas")
                .SetAutor("Linda Aleman")
                .SetFecha(DateTime.Now)
                .SetTablaDatos("ventas anuales")
                .SetConclusiones("Las ventas aumentaron un 20%")
                .Build();

            reporte.MostrarReporte();
        }
    }
}