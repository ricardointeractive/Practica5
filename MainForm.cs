/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 24/10/2013
 * Time: 07:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double tipoCambio;
        double peso;            
		double dolar;
		public MainForm()
		{
			 
            
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
            	//peso=System.Double.Parse(pesos.Text);
            	//tipoCambio=System.Double.Parse(tipocambio.Text);
            	
            	dolar=peso/tipoCambio;
            	//resultado.Text=dolar.ToString();     
            	if(!double.TryParse(pesos.Text,out peso)||!double.TryParse(tipocambio.Text,out tipoCambio)||peso==0 || tipoCambio==0){
            		MessageBox.Show("Error");
            	}
            	else{
            		resultado.Text=dolar.ToString();
            	}
            	}
                              	
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
