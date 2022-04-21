using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class CategoriaGramatical
    {
        public static string FIN_ARCHIVO = "@EOF@";
        public static string FIN_LINEA = "@FL@";
        public static string IDENTIFICADOR = "IDENTIFICADOR";
        public static string DECIMAL = "DECIMAL";
        public static string ENTERO = "ENTERO";
        public static string SUMA = "SUMA";
        public static string RESTA = "RESTA";
        public static string MULTIPLICACION = "MULTIPLICACION";
        public static string DIVISION = "DIVISION";
        public static string MODULO = "MODULO";
        public static string PARENTESIS_ABRE = "PARENTESIS_ABRE";
        public static string PARENTESIS_CIERRA = "PARENTESIS_CIERRA";
        public static string IGUAL_QUE = "IGUAL_QUE";
    }
}
