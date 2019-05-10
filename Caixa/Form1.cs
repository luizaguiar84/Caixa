using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Caixa
{
	public partial class Form1 : Form
	{

		public double CodProduto;
		public double QtdProduto;
		public double PrecoProd;
		// public double Total;




		private void MudarNoEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				this.ProcessTabKey(true);
				e.Handled = true;
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Entrada_box_TextChanged(object sender, EventArgs e)
		{

		}

		public void CodProduto_box_TextChanged(object sender, EventArgs e)
		{
		}

		private void CodProduto_box_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) {

				CodProduto = double.Parse(CodProduto_box.Text);
				this.ProcessTabKey(true);
				e.Handled = true;

			}
		}

		private void Quantidade_box_TextChanged(object sender, EventArgs e)
		{
			
		}


		private void Valor_box_TextChanged(object sender, EventArgs e)
		{
		

		}

		private void Quantidade_box_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{

				QtdProduto = double.Parse(Quantidade_box.Text);
				this.ProcessTabKey(true);
				e.Handled = true;

			}
		}

		private void Valor_box_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{

				PrecoProd = double.Parse(Valor_box.Text);


				this.ProcessTabKey(true);

				e.Handled = true;

				SubTotal_box.Text = ClassLibrary.Total.ToString("F2");


			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cobrar(QtdProduto, PrecoProd);

			
		}

		private void SubTotal_box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Avisos_box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 116)
				{

				Total_box.Text = Total.ToString("F2");


				}
			{

				PrecoProd = double.Parse(Valor_box.Text);

				Cobrar(QtdProduto, PrecoProd);

				this.ProcessTabKey(true);
				e.Handled = true;

				SubTotal_box.Text = Total.ToString("F2");


			}
		}
	}
}
