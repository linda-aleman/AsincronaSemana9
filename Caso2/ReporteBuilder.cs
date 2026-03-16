using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    public class ReporteBuilder
    {
        private string _titulo;
        private string _autor;
        private DateTime _fecha;
        private string _tablaDatos;
        private string _graficos;
        private string _conclusiones;

        public ReporteBuilder SetTitulo(string titulo)
        {
            _titulo = titulo;
            return this;
        }

        public ReporteBuilder SetAutor(string autor)
        {
            _autor = autor;
            return this;
        }

        public ReporteBuilder SetFecha(DateTime fecha)
        {
            _fecha = fecha;
            return this;
        }

        public ReporteBuilder SetTablaDatos(string tabla)
        {
            _tablaDatos = tabla;
            return this;
        }

        public ReporteBuilder SetGraficos(string graficos)
        {
            _graficos = graficos;
            return this;
        }

        public ReporteBuilder SetConclusiones(string conclusiones)
        {
            _conclusiones = conclusiones;
            return this;
        }

        public Reporte Build()
        {
            return new Reporte(_titulo, _autor, _fecha,
                               _tablaDatos, _graficos,
                               _conclusiones);
        }
    }
}
