﻿using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Cache
{
    public  class ProgramaFuente
    {
        private List<Linea> lineas = new List<Linea>();
        private static ProgramaFuente INSTANCIA = new ProgramaFuente();

        private ProgramaFuente()
        {

        }

        public static ProgramaFuente obtenerProgramaFuente()
        {
            return INSTANCIA;
        }

        public void inicializar()
        {
            lineas.Clear();
        }

        public void agregarLinea(String contenido)
        {
            
            agregarLinea(Linea.crear(obtenerNumeroSiguienteLinea(), obtenerValorDefecto(contenido)));
        }

        public void agregarLineas(List<Linea> lineas)
        {
            if(lineas != null)
            {
                inicializar();
                this.lineas = lineas;
            }
        }

        public Linea obtenerLinea(int numeroLinea)
        {
            if(numeroLinea < 0)
            {
                throw new Exception("Numero de linea no valido");
            }
            else if(numeroLinea > lineas.Count)
            {
                return Linea.crear(lineas.Count + 1, CategoriaGramatical.FIN_ARCHIVO);
            }
            else
            {
                return lineas.ElementAt(numeroLinea - 1);
            }
        }

        public List<Linea> obtenerLineas()
        {
            return lineas;
        }

        private void agregarLinea(Linea linea)
        {
            lineas.Add(linea);
        }



        private int obtenerNumeroSiguienteLinea()
        {
            return lineas.Count + 1;
        }

        private String obtenerValorDefecto(String cadena)
        {
            return (cadena == null) ? "" : cadena;
        }
    }
}
