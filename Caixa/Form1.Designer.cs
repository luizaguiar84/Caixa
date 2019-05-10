namespace Caixa
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.NomeEstabelecimento_lbl = new System.Windows.Forms.Label();
			this.ImagemEstabelecimento_lbl = new System.Windows.Forms.PictureBox();
			this.Avisos_box = new System.Windows.Forms.RichTextBox();
			this.Codigo_lbl = new System.Windows.Forms.Label();
			this.CodProduto_box = new System.Windows.Forms.RichTextBox();
			this.Quantidade_box = new System.Windows.Forms.RichTextBox();
			this.Valor_box = new System.Windows.Forms.RichTextBox();
			this.quantidade_lbl = new System.Windows.Forms.Label();
			this.valor_lbl = new System.Windows.Forms.Label();
			this.subtotal_lbl = new System.Windows.Forms.Label();
			this.SubTotal_box = new System.Windows.Forms.RichTextBox();
			this.Total_box = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ImagemEstabelecimento_lbl)).BeginInit();
			this.SuspendLayout();
			// 
			// NomeEstabelecimento_lbl
			// 
			this.NomeEstabelecimento_lbl.AutoSize = true;
			this.NomeEstabelecimento_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NomeEstabelecimento_lbl.Location = new System.Drawing.Point(205, 51);
			this.NomeEstabelecimento_lbl.Name = "NomeEstabelecimento_lbl";
			this.NomeEstabelecimento_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NomeEstabelecimento_lbl.Size = new System.Drawing.Size(618, 55);
			this.NomeEstabelecimento_lbl.TabIndex = 0;
			this.NomeEstabelecimento_lbl.Text = "Bar e Restaurante Brasinha";
			// 
			// ImagemEstabelecimento_lbl
			// 
			this.ImagemEstabelecimento_lbl.Image = global::Caixa.Properties.Resources._29425396_1653335641409619_1299821241396129622_n1;
			this.ImagemEstabelecimento_lbl.Location = new System.Drawing.Point(12, 12);
			this.ImagemEstabelecimento_lbl.Name = "ImagemEstabelecimento_lbl";
			this.ImagemEstabelecimento_lbl.Size = new System.Drawing.Size(130, 130);
			this.ImagemEstabelecimento_lbl.TabIndex = 1;
			this.ImagemEstabelecimento_lbl.TabStop = false;
			this.ImagemEstabelecimento_lbl.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Avisos_box
			// 
			this.Avisos_box.Location = new System.Drawing.Point(47, 148);
			this.Avisos_box.Name = "Avisos_box";
			this.Avisos_box.ReadOnly = true;
			this.Avisos_box.Size = new System.Drawing.Size(420, 344);
			this.Avisos_box.TabIndex = 2;
			this.Avisos_box.TabStop = false;
			this.Avisos_box.Text = "";
			this.Avisos_box.TextChanged += new System.EventHandler(this.Avisos_box_TextChanged);
			// 
			// Codigo_lbl
			// 
			this.Codigo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Codigo_lbl.Location = new System.Drawing.Point(500, 148);
			this.Codigo_lbl.Name = "Codigo_lbl";
			this.Codigo_lbl.Size = new System.Drawing.Size(76, 24);
			this.Codigo_lbl.TabIndex = 3;
			this.Codigo_lbl.Text = "Código";
			// 
			// CodProduto_box
			// 
			this.CodProduto_box.BackColor = System.Drawing.Color.White;
			this.CodProduto_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CodProduto_box.Location = new System.Drawing.Point(504, 175);
			this.CodProduto_box.MaxLength = 3;
			this.CodProduto_box.Multiline = false;
			this.CodProduto_box.Name = "CodProduto_box";
			this.CodProduto_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.CodProduto_box.Size = new System.Drawing.Size(397, 33);
			this.CodProduto_box.TabIndex = 4;
			this.CodProduto_box.Text = "";
			this.CodProduto_box.WordWrap = false;
			this.CodProduto_box.TextChanged += new System.EventHandler(this.CodProduto_box_TextChanged);
			this.CodProduto_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodProduto_box_KeyPress);
			// 
			// Quantidade_box
			// 
			this.Quantidade_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Quantidade_box.Location = new System.Drawing.Point(504, 238);
			this.Quantidade_box.MaxLength = 5;
			this.Quantidade_box.Multiline = false;
			this.Quantidade_box.Name = "Quantidade_box";
			this.Quantidade_box.Size = new System.Drawing.Size(397, 33);
			this.Quantidade_box.TabIndex = 5;
			this.Quantidade_box.Text = "";
			this.Quantidade_box.TextChanged += new System.EventHandler(this.Quantidade_box_TextChanged);
			this.Quantidade_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantidade_box_KeyPress);
			// 
			// Valor_box
			// 
			this.Valor_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Valor_box.Location = new System.Drawing.Point(504, 301);
			this.Valor_box.Multiline = false;
			this.Valor_box.Name = "Valor_box";
			this.Valor_box.Size = new System.Drawing.Size(397, 33);
			this.Valor_box.TabIndex = 6;
			this.Valor_box.Text = "";
			this.Valor_box.TextChanged += new System.EventHandler(this.Valor_box_TextChanged);
			this.Valor_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_box_KeyPress);
			// 
			// quantidade_lbl
			// 
			this.quantidade_lbl.AutoSize = true;
			this.quantidade_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantidade_lbl.Location = new System.Drawing.Point(500, 211);
			this.quantidade_lbl.Name = "quantidade_lbl";
			this.quantidade_lbl.Size = new System.Drawing.Size(108, 24);
			this.quantidade_lbl.TabIndex = 7;
			this.quantidade_lbl.Text = "Quantidade";
			// 
			// valor_lbl
			// 
			this.valor_lbl.AutoSize = true;
			this.valor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.valor_lbl.Location = new System.Drawing.Point(500, 274);
			this.valor_lbl.Name = "valor_lbl";
			this.valor_lbl.Size = new System.Drawing.Size(54, 24);
			this.valor_lbl.TabIndex = 8;
			this.valor_lbl.Text = "Valor";
			// 
			// subtotal_lbl
			// 
			this.subtotal_lbl.AutoSize = true;
			this.subtotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subtotal_lbl.Location = new System.Drawing.Point(500, 337);
			this.subtotal_lbl.Name = "subtotal_lbl";
			this.subtotal_lbl.Size = new System.Drawing.Size(77, 24);
			this.subtotal_lbl.TabIndex = 10;
			this.subtotal_lbl.Text = "Subtotal";
			// 
			// SubTotal_box
			// 
			this.SubTotal_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTotal_box.Location = new System.Drawing.Point(504, 364);
			this.SubTotal_box.Multiline = false;
			this.SubTotal_box.Name = "SubTotal_box";
			this.SubTotal_box.ReadOnly = true;
			this.SubTotal_box.Size = new System.Drawing.Size(397, 33);
			this.SubTotal_box.TabIndex = 11;
			this.SubTotal_box.Text = "";
			this.SubTotal_box.TextChanged += new System.EventHandler(this.SubTotal_box_TextChanged);
			// 
			// Total_box
			// 
			this.Total_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total_box.Location = new System.Drawing.Point(504, 459);
			this.Total_box.Multiline = false;
			this.Total_box.Name = "Total_box";
			this.Total_box.ReadOnly = true;
			this.Total_box.Size = new System.Drawing.Size(397, 33);
			this.Total_box.TabIndex = 12;
			this.Total_box.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(500, 432);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "TOTAL";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(968, 547);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Total_box);
			this.Controls.Add(this.SubTotal_box);
			this.Controls.Add(this.subtotal_lbl);
			this.Controls.Add(this.valor_lbl);
			this.Controls.Add(this.quantidade_lbl);
			this.Controls.Add(this.Valor_box);
			this.Controls.Add(this.Quantidade_box);
			this.Controls.Add(this.CodProduto_box);
			this.Controls.Add(this.Codigo_lbl);
			this.Controls.Add(this.Avisos_box);
			this.Controls.Add(this.ImagemEstabelecimento_lbl);
			this.Controls.Add(this.NomeEstabelecimento_lbl);
			this.Name = "Form1";
			this.Text = "Caixa";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.ImagemEstabelecimento_lbl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NomeEstabelecimento_lbl;
		private System.Windows.Forms.PictureBox ImagemEstabelecimento_lbl;
		private System.Windows.Forms.RichTextBox Avisos_box;
		private System.Windows.Forms.Label Codigo_lbl;
		public System.Windows.Forms.RichTextBox CodProduto_box;
		private System.Windows.Forms.RichTextBox Quantidade_box;
		private System.Windows.Forms.RichTextBox Valor_box;
		private System.Windows.Forms.Label quantidade_lbl;
		private System.Windows.Forms.Label valor_lbl;
		private System.Windows.Forms.Label subtotal_lbl;
		private System.Windows.Forms.RichTextBox SubTotal_box;
		private System.Windows.Forms.RichTextBox Total_box;
		private System.Windows.Forms.Label label1;
	}
}

