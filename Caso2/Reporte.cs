using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    // Producto
    public class Reporte
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public DateTime Fecha { get; private set; }
        public string TablaDatos { get; private set; }
        public string Graficos { get; private set; }
        public string Conclusiones { get; private set; }

        internal Reporte(string titulo, string autor, DateTime fecha,
                         string tablaDatos, string graficos,
                         string conclusiones)
        {
            Titulo = titulo;
            Autor = autor;
            Fecha = fecha;
            TablaDatos = tablaDatos;
            Graficos = graficos;
            Conclusiones = conclusiones;
        }

        public void MostrarReporte()
        {
            Console.WriteLine("=== REPORTE ===");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Tabla de Datos: {TablaDatos}");
            Console.WriteLine($"Gráficos: {Graficos}");
            Console.WriteLine($"Conclusiones: {Conclusiones}");
        }
    }
}
