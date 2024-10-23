/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 23/10/2024
 * Time: 07:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularRFCClick(object sender, EventArgs e)
		{
			// Recojemos los datos ingresados por el usuario
            string nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string semestre = comboBoxSemestre.SelectedItem.ToString();
            DateTime fechaNacimiento = dateTimePickerSI.Value;
			
            // Calculamos el RFC mediante un metodo y lo mostramos al usuario
            string rfc = CalcularRFC(nombre, apellido1, apellido2, fechaNacimiento);
            MessageBox.Show("El RFC es: " + rfc);
        }

        private string CalcularRFC(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
        	// Recojemos las iniciales de los apellidos
            string inicialApellido1 = apellido1.Substring(0, 1).ToUpper();
            string inicialNombre = nombre.Substring(0, 1).ToUpper();
            string inicialApellido2;
            char vocal = 'x';
            // Recojemos la primera vocal del primer apellido
            for(int i=0;i<apellido1.Length;++i)
            {
            	if(apellido1[i]=='a')
            	{
            		vocal = 'a';
            		break;
            	}
            	else if(apellido1[i]=='e')
            	{
            		vocal = 'e';
            		break;
            	}
            	else if(apellido1[i]=='i')
            	{
            		vocal = 'i';
            		break;
            	}
            	else if(apellido1[i]=='o')
            	{
            		vocal = 'o';
            		break;
            	}
            	else if(apellido1[i]=='u')
            	{
            		vocal = 'u';
            		break;
            	}
            }
            
            // Usamos la inicial del primer apellido si no hay segundo
            if (!string.IsNullOrEmpty(apellido2))
            {
                inicialApellido2 = apellido2.Substring(0, 1).ToUpper();
            }
            else
            {
                inicialApellido2 = inicialApellido1;
            }
            
            // Creamos aleatoriamente 3 caracteres para usar al final del RFC
            string fechaRFC = fechaNacimiento.ToString("yyMMdd");
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        	Random random = new Random();
        	char[] cadenaAleatoria = new char[3];

        	for (int i = 0; i < cadenaAleatoria.Length; i++)
        	{
            	int indice = random.Next(caracteres.Length);
            	cadenaAleatoria[i] = caracteres[indice];
        	}

        	string resultado = new string(cadenaAleatoria);
        	
        	// Retornamos la cadena que sera usada en main
            return inicialApellido1 + char.ToUpper(vocal) + inicialApellido2 + inicialNombre + fechaRFC + resultado;
        }
	}
}
