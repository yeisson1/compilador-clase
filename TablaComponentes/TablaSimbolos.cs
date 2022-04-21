using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public class TablaSimbolos: TablaMaestra
    {
        private static TablaSimbolos INSTANCIA = new TablaSimbolos();

        private TablaSimbolos()
        {
            asignarTipo(Transversal.TipoComponente.SIMBOLO);
        }

        public static TablaSimbolos obtenerTabla()
        {
            return INSTANCIA;
        }
    }
}
