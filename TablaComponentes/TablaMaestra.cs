using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public  class TablaMaestra
    {
        private Dictionary<string, List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();
        private TipoComponente tipo;

        protected void asignarTipo(TipoComponente tipo)
        {
            this.tipo = tipo;
        }

        public virtual void Agregar(ComponenteLexico componente)
        {
            if (componente != null && tipo.Equals(componente.obtenerTipo()))
            {
                obtenerComponentes(componente.obtenerLexema()).Add(componente);            }

        }

        private List<ComponenteLexico> obtenerComponentes(string clave)
        {
            if (tabla.ContainsKey(clave))
            {
                tabla.Add(clave, new List<ComponenteLexico>());
            }

            return tabla[clave];
        }

        public List<ComponenteLexico> obtenerComponentes()
        {
            List<ComponenteLexico> lista = new List<ComponenteLexico>();

            foreach(List<ComponenteLexico> componentes in tabla.Values)
            {
                lista.AddRange(componentes);
            }

            return lista;
        }

        public void reiniciar()
        {
            tabla.Clear();
        }
    }
}
