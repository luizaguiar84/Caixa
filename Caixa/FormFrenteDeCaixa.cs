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
	public partial class FormFrenteDeCaixa : Form
	{

		public double CodProduto;
		public double QtdProduto;
		public double PrecoProd;
		public double Total;
		public double SubTotal { get; set; }

		Totalizacao totalizacao = new Totalizacao();
		ClassLibrary.Operacoes operacoes = new ClassLibrary.Operacoes();


		private void MudarNoEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				this.ProcessTabKey(true);
				e.Handled = true;
			}
		}

		public FormFrenteDeCaixa()
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

				double subtotal = operacoes.Cobrar(QtdProduto, PrecoProd);

				SubTotal += subtotal;
				Total += subtotal;

				CodProduto_box.Focus();
				//"C" no tostring de currency
				
				SubTotal_box.Text = SubTotal.ToString("C");

				Valor_box.Text = "";
				CodProduto_box.Text = "";
				Quantidade_box.Text = "";
				Avisos_box.Text += "Codigo: " + CodProduto +
									" Quantidade: " + QtdProduto +
									" Valor Unitário: " + PrecoProd.ToString("C") +
									" TOTAL= " + (QtdProduto*PrecoProd).ToString("C") + "\n\n";


			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Cobrar(QtdProduto, PrecoProd);

			
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

				//Total_box.Text = Total.ToString("F2");


				}
			{

				PrecoProd = double.Parse(Valor_box.Text);

				//Cobrar(QtdProduto, PrecoProd);

				this.ProcessTabKey(true);
				e.Handled = true;

				//SubTotal_box.Text = Total.ToString("F2");


			}
		}

		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			txtTotal.Text = Total.ToString("C");

		}

		private void brnNovaVenda_Click(object sender, EventArgs e)
		{
			FormFormasDePagamento formFormasDePagamento = new FormFormasDePagamento();
			formFormasDePagamento.Show();
			formFormasDePagamento.lbl_FormaDePagamento.Text = "Valor Total: " + Total.ToString("C");
			Valor_box.Text = "";
			CodProduto_box.Text = "";
			Quantidade_box.Text = "";
			txtTotal.Text = "";
			SubTotal_box.Text = "";
			Avisos_box.Text = "";
			Total = 0;
			SubTotal = 0;


		}
	}
}
