/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 23/10/2024
 * Time: 07:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido1 = new System.Windows.Forms.TextBox();
			this.txtApellido2 = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
			this.dateTimePickerSI = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCalcularRFC = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre(s)";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido Paterno";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido Materno";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Telefono";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Direccion";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Semestre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(103, 13);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(99, 23);
			this.txtNombre.TabIndex = 6;
			// 
			// txtApellido1
			// 
			this.txtApellido1.Location = new System.Drawing.Point(103, 48);
			this.txtApellido1.Multiline = true;
			this.txtApellido1.Name = "txtApellido1";
			this.txtApellido1.Size = new System.Drawing.Size(99, 23);
			this.txtApellido1.TabIndex = 7;
			// 
			// txtApellido2
			// 
			this.txtApellido2.Location = new System.Drawing.Point(103, 95);
			this.txtApellido2.Multiline = true;
			this.txtApellido2.Name = "txtApellido2";
			this.txtApellido2.Size = new System.Drawing.Size(99, 23);
			this.txtApellido2.TabIndex = 8;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(103, 133);
			this.txtTelefono.Multiline = true;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(99, 23);
			this.txtTelefono.TabIndex = 9;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(103, 173);
			this.txtDireccion.Multiline = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(99, 23);
			this.txtDireccion.TabIndex = 10;
			// 
			// comboBoxSemestre
			// 
			this.comboBoxSemestre.FormattingEnabled = true;
			this.comboBoxSemestre.Items.AddRange(new object[] {
									"1er Semestre",
									"2do Semestre",
									"3er Semestre",
									"4to Semestre",
									"5to Semestre",
									"6to Semestre"});
			this.comboBoxSemestre.Location = new System.Drawing.Point(103, 215);
			this.comboBoxSemestre.Name = "comboBoxSemestre";
			this.comboBoxSemestre.Size = new System.Drawing.Size(99, 21);
			this.comboBoxSemestre.TabIndex = 11;
			// 
			// dateTimePickerSI
			// 
			this.dateTimePickerSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerSI.Location = new System.Drawing.Point(103, 256);
			this.dateTimePickerSI.Name = "dateTimePickerSI";
			this.dateTimePickerSI.Size = new System.Drawing.Size(242, 22);
			this.dateTimePickerSI.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 256);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 33);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fecha de Nacimiento";
			// 
			// btnCalcularRFC
			// 
			this.btnCalcularRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcularRFC.Location = new System.Drawing.Point(12, 303);
			this.btnCalcularRFC.Name = "btnCalcularRFC";
			this.btnCalcularRFC.Size = new System.Drawing.Size(342, 29);
			this.btnCalcularRFC.TabIndex = 14;
			this.btnCalcularRFC.Text = "Calcular RFC";
			this.btnCalcularRFC.UseVisualStyleBackColor = true;
			this.btnCalcularRFC.Click += new System.EventHandler(this.BtnCalcularRFCClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 344);
			this.Controls.Add(this.btnCalcularRFC);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePickerSI);
			this.Controls.Add(this.comboBoxSemestre);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtApellido2);
			this.Controls.Add(this.txtApellido1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcularRFC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimePickerSI;
		private System.Windows.Forms.ComboBox comboBoxSemestre;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtApellido2;
		private System.Windows.Forms.TextBox txtApellido1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
