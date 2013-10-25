/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 24/10/2013
 * Time: 07:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pesos = new System.Windows.Forms.TextBox();
			this.Convertir = new System.Windows.Forms.Button();
			this.tipocambio = new System.Windows.Forms.TextBox();
			this.resultado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pesos
			// 
			this.pesos.Location = new System.Drawing.Point(29, 65);
			this.pesos.Name = "pesos";
			this.pesos.Size = new System.Drawing.Size(100, 20);
			this.pesos.TabIndex = 0;
			this.pesos.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// Convertir
			// 
			this.Convertir.Location = new System.Drawing.Point(156, 127);
			this.Convertir.Name = "Convertir";
			this.Convertir.Size = new System.Drawing.Size(100, 30);
			this.Convertir.TabIndex = 1;
			this.Convertir.Text = "Convertir";
			this.Convertir.UseVisualStyleBackColor = true;
			this.Convertir.Click += new System.EventHandler(this.Button1Click);
			// 
			// tipocambio
			// 
			this.tipocambio.Location = new System.Drawing.Point(156, 65);
			this.tipocambio.Name = "tipocambio";
			this.tipocambio.Size = new System.Drawing.Size(100, 20);
			this.tipocambio.TabIndex = 2;
			this.tipocambio.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// resultado
			// 
			this.resultado.Location = new System.Drawing.Point(29, 127);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(100, 20);
			this.resultado.TabIndex = 3;
			this.resultado.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pesos";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(156, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tipo de cambio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Dolares";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 183);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.tipocambio);
			this.Controls.Add(this.Convertir);
			this.Controls.Add(this.pesos);
			this.Name = "MainForm";
			this.Text = "practica5";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox resultado;
		private System.Windows.Forms.TextBox tipocambio;
		private System.Windows.Forms.Button Convertir;
		private System.Windows.Forms.TextBox pesos;
	}
}
