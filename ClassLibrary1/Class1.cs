using System;
using Caixa;


namespace ClassLibrary1
{
	public class Class1
	{
		public int Codigo { get; set; };
		public int Quantidade { get; set; };
		public Double Valor { get; set; };

		public void Cobrar()
		{
			int Codigo = Caixa.Form1.Entrada_box;


		}
	}
}
