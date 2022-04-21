using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public class TablaLiterales: TablaMaestra
    {
        private static TablaLiterales INSTANCIA = new TablaLiterales();

        private TablaLiterales()
        {
            asignarTipo(Transversal.TipoComponente.LITERAL);
        }

        public static TablaLiterales obtenerTabla()
        {
            return INSTANCIA;
        }
    }
        
    
}
