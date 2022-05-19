using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compilador.AnalisisLexico;

namespace Compilador.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private ComponenteLexico componente;
        private AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();

        private void pedirComponente()
        {
            componente = analizadorLexico.devolverSiguienteComponente();
        }

		public void analizar()
		{
			pedirComponente();
			primera();

			if (ManejadorError.obtenerManejadorInstancia().hayErrores())
			{
				MessageBox.Show("hay errores decomplicaion,Por favor verifique lso reportes de errores respectivos");
			}

			else if ("FIN_ARCHIVO".Equals(componente.obtenerCategoria().ToUpper()))
			{

				MessageBox.Show("El programa se encuentra bien escrito");
			}
			else
			{
				MessageBox.Show("Faltaron componentes por evaluar sintacticamente");
			}
		}

		private void primera()
		{
			segunda();
			primeraPrima();
}

		private void primeraPrima()
		{
			if ("SUMA".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();
				primera();

			}
			else if("RESTA".Equals(componente.obtenerCategoria().ToUpper())){
				pedirComponente();
				primera();

			}

		}


		private void segunda()
		{
			tercera();
			segundaPrima();
		}

		private void segundaPrima()
		{
			if ("MULTIPLICACION".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();
				segunda();

			}
			else if("DIVISION".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();
				segunda();

			}
		}

		private void tercera()
		{
			if ("NUMERO_ENTERO".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();

			}
			else if ("NUMERO_DECIMAL".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();
			}
			else if ("PARENTESIS_ABRE".Equals(componente.obtenerCategoria().ToUpper()))
			{
				pedirComponente();
				primera();

				if ("PARENTESIS_ABRE".Equals(componente.obtenerCategoria().ToUpper()))
				{

					pedirComponente();
				}
				else
				{

					//manejador de errores

					//falla:componente no esperado
					//Causa: No es entero, decimal o parentesis abre
					//Solucion: Asegurese que esta posicion exista un componnete de tipo entero, decimal,parentesis abre
					throw Exception("Se presento error");
				}
			}
			else
			{

				//manejador de errores

				//falla:componente no esperado
				//Causa: No es entero, decimal o parentesis abre
				//Solucion: Asegurese que esta posicion exista un componnete de tipo entero, decimal,parentesis abre
				throw Exception("Se presento error de tipo stopper durante el analisis sintactico. Por favor verifique laconsola de errores");
			}


		}





	}
}

