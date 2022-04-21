using Compilador.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compilador.Transversal;
using Compilador.AnalisisLexico;

namespace Compilador.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int numeroLineaActual;
        private int apuntador;
        private String caracterActual;
        private String contenidoLineaActual;


        private AnalizadorLexico()
        {
            cargarNuevaLinea();
        }

        public static AnalizadorLexico crear()
        {
            return new AnalizadorLexico();
        }

        private void cargarNuevaLinea()
        {
            numeroLineaActual = numeroLineaActual + 1;
            Linea lineaActual = ProgramaFuente.obtenerProgramaFuente().obtenerLinea(numeroLineaActual);
            contenidoLineaActual = lineaActual.obtenerContenido();
            numeroLineaActual = lineaActual.obtenerNumeroLinea();
            apuntador = 1;
    
        }

        private void leerSiguienteCaracter()
        {
            if (CategoriaGramatical.FIN_ARCHIVO.Equals(contenidoLineaActual))
            {
                caracterActual = contenidoLineaActual;
            } else if(apuntador > contenidoLineaActual.Length)
            {
                caracterActual = CategoriaGramatical.FIN_LINEA;
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(apuntador - 1, 1);
                apuntador = apuntador + 1;
            }
        }

        private void devolverPuntero()
        {
            apuntador = apuntador - 1;
        }

        private bool esLetra()
        {
            return Char.IsLetter(caracterActual.ToCharArray()[0]);
        }

        private bool esDigito()
        {
            return Char.IsDigit(caracterActual.ToCharArray()[0]);
        }

        private bool esIgual(String cadenaUno, String cadenaDos)
        {
            if(cadenaUno == null && cadenaDos == null)
            {
                return true;
            }
            else if(cadenaUno == null)
            {
                return false;
            }
            return cadenaUno.Equals(cadenaDos);
        }
        private bool esPesos()
        {
            return esIgual("$", caracterActual);
        }

        private bool esGuionBajo()
        {
            return esIgual("_", caracterActual);
        }

        private bool esPunto()
        {
            return esIgual(".", caracterActual);
        }

        private bool esSuma()
        {
            return esIgual("+", caracterActual);
        }

        private bool esResta()
        {
            return esIgual("-", caracterActual);
        }

        private bool esMultiplicacion()
        {
            return esIgual("*", caracterActual);
        }

        private bool esDivision()
        {
            return esIgual("/", caracterActual);
        }

        private bool esPorcentaje()
        {
            return esIgual("/", caracterActual);
        }

        private bool esParentesisAbre()
        {
            return esIgual("(", caracterActual);
        }

        private bool esParentesisCierra()
        {
            return esIgual(")", caracterActual);
        }

        private bool esIgualacion()
        {
            return esIgual("=", caracterActual);
        }

        private bool esSignoMayor()
        {
            return esIgual(">", caracterActual);
        }

        private bool esSignoMenor()
        {
            return esIgual("<", caracterActual);
        }

        private bool esDosPuntos()
        {
            return esIgual(":", caracterActual);
        }

        private bool esAdmiracion()
        {
            return esIgual("!", caracterActual);
        }

        private bool esFinLinea()
        {
            return esIgual(CategoriaGramatical.FIN_LINEA, caracterActual);
        }

        private bool esFinArchivo()
        {
            return esIgual(CategoriaGramatical.FIN_ARCHIVO, caracterActual);
        }

        public ComponenteLexico devolverSiguienteComponente()
        {
            ComponenteLexico retorno = null;
            int estadoActual = 0;
            string lexema = "";
            bool continuarAnalisis = true;

            while (continuarAnalisis)
            {
                if(estadoActual == 0)
                {
                    leerSiguienteCaracter();
                    while(" ".Equals(caracterActual))
                    {
                        leerSiguienteCaracter();
                    }
                    if (esLetra() || esPesos() || esGuionBajo())
                    {
                        estadoActual = 4;
                        lexema = lexema + caracterActual;
                    }
                    else if (esDigito())
                    {
                        estadoActual = 1;
                        lexema = lexema + caracterActual;
                    }
                    else if (esFinLinea())
                    {
                        estadoActual = 13;
                    }
                    else if (esSuma())
                    {
                        estadoActual = 5;
                        lexema = lexema + caracterActual;
                    }
                    else if (esResta())
                    {
                        estadoActual = 6;
                        lexema = lexema + caracterActual;
                    }
                    else if (esMultiplicacion())
                    {
                        estadoActual = 7;
                        lexema = lexema + caracterActual;
                    }
                    else if (esDivision())
                    {
                        estadoActual = 8;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPorcentaje())
                    {
                        estadoActual = 9;
                        lexema = lexema + caracterActual;
                    }
                    else if (esParentesisAbre())
                    {
                        estadoActual = 10;
                        lexema = lexema + caracterActual;
                    }
                    else if (esParentesisCierra())
                    {
                        estadoActual = 11;
                        lexema = lexema + caracterActual;
                    }
                    else if (esIgualacion())
                    {
                        estadoActual = 19;
                        lexema = lexema + caracterActual;
                    }
                    else if (esFinArchivo())
                    {
                        estadoActual = 12;
                        
                    }
                    else if (esSignoMayor())
                    {
                        estadoActual = 21;
                        lexema = lexema + caracterActual;
                    }
                    else if (esSignoMenor())
                    {
                        estadoActual = 20;
                        lexema = lexema + caracterActual;
                    }
                    else if (esAdmiracion())
                    {
                        estadoActual = 20;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoActual = 18;
                    }
                    
                }
                else if (estadoActual == 1)
                {
                    leerSiguienteCaracter();
                    if (esDigito())
                    {
                        estadoActual = 1;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoActual = 2;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoActual = 14;
                    }
                }
                else if (estadoActual == 2)
                {
                    leerSiguienteCaracter();
                    if (esDigito())
                    {
                        estadoActual = 3;
                        lexema = lexema + caracterActual;
                    }
                    
                    else
                    {
                        estadoActual = 17;
                    }

                }
                else if (estadoActual == 3)
                {
                    leerSiguienteCaracter();
                    if (esDigito())
                    {
                        estadoActual = 3;
                        lexema = lexema + caracterActual;
                    }

                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 4)
                {
                    leerSiguienteCaracter();

                    if(esLetra() || esDigito() || esGuionBajo() || esPesos())
                    {
                        estadoActual = 4;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoActual = 16;
                    }
                }
                else if (estadoActual == 5)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.SUMA, lexema);
                }
                else if (estadoActual == 6)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.RESTA, lexema);
                }
                else if (estadoActual == 7)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.MULTIPLICACION, lexema);
                }
                else if (estadoActual == 8)
                {
                    leerSiguienteCaracter();

                    if (esMultiplicacion())
                    {
                        estadoActual = 34;
                        lexema = lexema + caracterActual;
                    }
                    else if (esDivision())
                    {
                        estadoActual = 36;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoActual = 33;
                    }
                }
                else if (estadoActual == 9)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.MODULO, lexema);
                }
                else if (estadoActual == 10)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.PARENTESIS_ABRE, lexema);
                }
                else if (estadoActual == 11)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.PARENTESIS_CIERRA, lexema);
                }
                else if (estadoActual == 12)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.FIN_ARCHIVO, lexema);
                }
                else if (estadoActual == 13)
                {
                    cargarNuevaLinea();
                    estadoActual = 0;

                }
                else if (estadoActual == 14)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crearSimbolo(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.ENTERO, lexema);
                }
                else if (estadoActual == 15)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crearSimbolo(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.DECIMAL, lexema);
                }
                else if (estadoActual == 16)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crearSimbolo(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.IDENTIFICADOR, lexema);
                    
                }
                else if (estadoActual == 17)
                {
                    // falta gestor de errores
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crearDummy(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.DECIMAL, lexema + "0");
                   
                }
                else if (estadoActual == 18)
                {
                    throw new Exception("Error critico de tipo lexico: Se detuvo el analisis!!!");
                }
                else if (estadoActual == 19)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crearLiteral(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.IGUAL_QUE, lexema);

                }
                else if (estadoActual == 20)
                {

                }
                else if (estadoActual == 21)
                {


                }
                else if (estadoActual == 22)
                {

                }
                else if (estadoActual == 23)
                {

                }
                else if (estadoActual == 24)
                {

                }
                else if (estadoActual == 25)
                {

                }
                else if (estadoActual == 26)
                {

                }
                else if (estadoActual == 27)
                {

                }
                else if (estadoActual == 28)
                {

                }
                else if (estadoActual == 29)
                {

                }
                else if (estadoActual == 30)
                {

                }
                else if (estadoActual == 31)
                {

                }
                else if (estadoActual == 32)
                {

                }
                else if (estadoActual == 33)
                {

                }
                else if (estadoActual == 34)
                {

                }
                else if (estadoActual == 35)
                {

                }
                else if (estadoActual == 36)
                {

                }
            }
            TablaComponentes.Tabla.obtenerTabla().Agregar(retorno);
            return retorno;
        }       

    }
}

