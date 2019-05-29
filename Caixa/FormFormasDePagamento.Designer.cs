namespace Caixa
{
	partial class FormFormasDePagamento
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_FormaDePagamento = new System.Windows.Forms.Label();
			this.brnPagar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_FormaDePagamento
			// 
			this.lbl_FormaDePagamento.AutoSize = true;
			this.lbl_FormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_FormaDePagamento.Location = new System.Drawing.Point(54, 28);
			this.lbl_FormaDePagamento.Name = "lbl_FormaDePagamento";
			this.lbl_FormaDePagamento.Size = new System.Drawing.Size(60, 24);
			this.lbl_FormaDePagamento.TabIndex = 0;
			this.lbl_FormaDePagamento.Text = "label1";
			this.lbl_FormaDePagamento.Click += new System.EventHandler(this.lbl_FormaDePagamento_Click);
			// 
			// brnPagar
			// 
			this.brnPagar.Location = new System.Drawing.Point(279, 241);
			this.brnPagar.Name = "brnPagar";
			this.brnPagar.Size = new System.Drawing.Size(75, 23);
			this.brnPagar.TabIndex = 1;
			this.brnPagar.Text = "Pagar";
			this.brnPagar.UseVisualStyleBackColor = true;
			this.brnPagar.Click += new System.EventHandler(this.brnPagar_Click);
			// 
			// FormFormasDePagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 327);
			this.ControlBox = false;
			this.Controls.Add(this.brnPagar);
			this.Controls.Add(this.lbl_FormaDePagamento);
			this.Name = "FormFormasDePagamento";
			this.Text = "FormFormasDePagamento";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lbl_FormaDePagamento;
		private System.Windows.Forms.Button brnPagar;
	}
}