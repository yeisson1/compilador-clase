using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public class TablaDummys:TablaMaestra
    {
        private static TablaDummys INSTANCIA = new TablaDummys();

        private TablaDummys()
        {
            asignarTipo(Transversal.TipoComponente.DUMMY);
        }

        public static TablaDummys obtenerTabla()
        {
            return INSTANCIA;
        }
    }
}
