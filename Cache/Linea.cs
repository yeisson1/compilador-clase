using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Cache
{
    public class Linea
    {
        private int numeroLinea;
        private String contenido;

        private Linea(int numeroLinea, String contenido)
        {
            this.numeroLinea = numeroLinea;
            this.contenido = contenido;
        }

        public static Linea crear(int numeroLinea, String contenido)
        {
            return new Linea(numeroLinea, contenido);
        }

        public int obtenerNumeroLinea()
        {
            return numeroLinea;
        }

        public String obtenerContenido()
        {
            return contenido;
        }
    }
}
