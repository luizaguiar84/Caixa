using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	class Operacoes
	{
		public int Valor { get; set; }
		public int MyProperty { get; set; }
		public double Total { get; set; }

		public void Cobrar(double qtd, double preco)
		{

		Total = qtd * preco;

		}
	}
}
