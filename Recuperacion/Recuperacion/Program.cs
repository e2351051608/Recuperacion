using System;

namespace Recuperacion
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero;
			Console.WriteLine("=====================================");
			Console.WriteLine("             Bienvenidos             ");
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			Console.WriteLine("  Escoja un procedimiento a realizar ");
			Console.WriteLine("=====================================");
			Console.WriteLine("*  1-Registro de las embarcaciones.  ");
			Console.WriteLine("*  2-Alquiler de espacios.    	    ");
			Console.WriteLine("*  3-Consulta de espacios.  		    ");
			Console.WriteLine("*  0- Salir.                         ");

			if (numero == 1)
			{
				Cliente cliente = new Cliente();
				cliente.imprimirCliente();

				Barco barco = new Barco();
				barco.imprimirBarco();
			}
			else
				if (numero == 2)
            {
				Alquiler alquiler = new Alquiler();
				alquiler.imprimirAlquiler();

				TipoBarco = new TipoBarco();
				TipoBarco.imprimirTipoBarco();
			}
			else
				if (numero == 3)
            {
				Consulta Consulta = new Consulta();
				Consulta.imprimirConsulta();
			}

		}
		
	}
}
