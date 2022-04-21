using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public class Tabla
    {
        private static Tabla INSTANCIA = new Tabla();

        private Tabla()
        {

        }

        public static Tabla obtenerTabla()
        {
            return INSTANCIA;
        }

        public void Agregar(ComponenteLexico componente)
        {
            TablaPalabrasReservadas.obtenerTabla().Agregar(componente);
            TablaSimbolos.obtenerTabla().Agregar(componente);
            TablaLiterales.obtenerTabla().Agregar(componente);  
            TablaDummys.obtenerTabla().Agregar(componente); 
        }

        public void reiniciar()
        {
            TablaPalabrasReservadas.obtenerTabla().reiniciar();
            TablaSimbolos.obtenerTabla().reiniciar();
            TablaLiterales.obtenerTabla().reiniciar();
            TablaDummys.obtenerTabla().reiniciar();
        }

        public List<ComponenteLexico> obtenerComponentes(TipoComponente tipo)
        {

            List<ComponenteLexico> lista = new List<ComponenteLexico>();

            if (TipoComponente.LITERAL.Equals(tipo))
            {
                lista = TablaLiterales.obtenerTabla().obtenerComponentes();
            }
            else if (TipoComponente.PALABRA_RESERVADA.Equals(tipo))
            {
                lista = TablaPalabrasReservadas.obtenerTabla().obtenerComponentes();
            }
            else if (TipoComponente.SIMBOLO.Equals(tipo))
            {
                lista = TablaSimbolos.obtenerTabla().obtenerComponentes();
            }
            else if(TipoComponente.DUMMY.Equals(tipo))
            {
                lista = TablaDummys.obtenerTabla().obtenerComponentes();
            }

            return lista;
        }
    }
}

