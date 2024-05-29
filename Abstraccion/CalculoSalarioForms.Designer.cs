namespace CalculoSalariaForms
{
    partial class CalculoSalarioForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoSalarioForms));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbxGenero = new System.Windows.Forms.ComboBox();
            this.TxtIngresoIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtIngresoNombre = new System.Windows.Forms.TextBox();
            this.TxtDiasLaborados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSalarioDiaFalse = new System.Windows.Forms.TextBox();
            this.GBOX1 = new System.Windows.Forms.GroupBox();
            this.ChkAdministrativo = new System.Windows.Forms.RadioButton();
            this.ChkServiciosGenerales = new System.Windows.Forms.RadioButton();
            this.ChkSoldador = new System.Windows.Forms.RadioButton();
            this.ChkMecanico = new System.Windows.Forms.RadioButton();
            this.ChkElectricista = new System.Windows.Forms.RadioButton();
            this.errorProviderIdentificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCalcularSalario = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardarRegistro = new System.Windows.Forms.Button();
            this.GBOX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dias Laborados";
            // 
            // CmbxGenero
            // 
            this.CmbxGenero.FormattingEnabled = true;
            this.CmbxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "LGBTIQ+"});
            this.CmbxGenero.Location = new System.Drawing.Point(551, 98);
            this.CmbxGenero.Name = "CmbxGenero";
            this.CmbxGenero.Size = new System.Drawing.Size(121, 21);
            this.CmbxGenero.TabIndex = 8;
            // 
            // TxtIngresoIdentificacion
            // 
            this.TxtIngresoIdentificacion.Location = new System.Drawing.Point(184, 103);
            this.TxtIngresoIdentificacion.Name = "TxtIngresoIdentificacion";
            this.TxtIngresoIdentificacion.Size = new System.Drawing.Size(170, 20);
            this.TxtIngresoIdentificacion.TabIndex = 9;
            // 
            // TxtIngresoNombre
            // 
            this.TxtIngresoNombre.Location = new System.Drawing.Point(184, 144);
            this.TxtIngresoNombre.Name = "TxtIngresoNombre";
            this.TxtIngresoNombre.Size = new System.Drawing.Size(170, 20);
            this.TxtIngresoNombre.TabIndex = 10;
            // 
            // TxtDiasLaborados
            // 
            this.TxtDiasLaborados.Location = new System.Drawing.Point(551, 207);
            this.TxtDiasLaborados.Name = "TxtDiasLaborados";
            this.TxtDiasLaborados.Size = new System.Drawing.Size(121, 20);
            this.TxtDiasLaborados.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salario Dia";
            // 
            // TxtSalarioDiaFalse
            // 
            this.TxtSalarioDiaFalse.Enabled = false;
            this.TxtSalarioDiaFalse.Location = new System.Drawing.Point(551, 155);
            this.TxtSalarioDiaFalse.Name = "TxtSalarioDiaFalse";
            this.TxtSalarioDiaFalse.Size = new System.Drawing.Size(121, 20);
            this.TxtSalarioDiaFalse.TabIndex = 13;
            // 
            // GBOX1
            // 
            this.GBOX1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBOX1.Controls.Add(this.ChkAdministrativo);
            this.GBOX1.Controls.Add(this.ChkServiciosGenerales);
            this.GBOX1.Controls.Add(this.ChkSoldador);
            this.GBOX1.Controls.Add(this.ChkMecanico);
            this.GBOX1.Controls.Add(this.ChkElectricista);
            this.GBOX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX1.Location = new System.Drawing.Point(126, 184);
            this.GBOX1.Name = "GBOX1";
            this.GBOX1.Size = new System.Drawing.Size(239, 107);
            this.GBOX1.TabIndex = 14;
            this.GBOX1.TabStop = false;
            // 
            // ChkAdministrativo
            // 
            this.ChkAdministrativo.AutoSize = true;
            this.ChkAdministrativo.Location = new System.Drawing.Point(101, 32);
            this.ChkAdministrativo.Name = "ChkAdministrativo";
            this.ChkAdministrativo.Size = new System.Drawing.Size(101, 19);
            this.ChkAdministrativo.TabIndex = 4;
            this.ChkAdministrativo.TabStop = true;
            this.ChkAdministrativo.Text = "Administrativo";
            this.ChkAdministrativo.UseVisualStyleBackColor = true;
            // 
            // ChkServiciosGenerales
            // 
            this.ChkServiciosGenerales.AutoSize = true;
            this.ChkServiciosGenerales.Location = new System.Drawing.Point(101, 9);
            this.ChkServiciosGenerales.Name = "ChkServiciosGenerales";
            this.ChkServiciosGenerales.Size = new System.Drawing.Size(131, 19);
            this.ChkServiciosGenerales.TabIndex = 3;
            this.ChkServiciosGenerales.TabStop = true;
            this.ChkServiciosGenerales.Text = "ServiciosGenerales";
            this.ChkServiciosGenerales.UseVisualStyleBackColor = true;
            // 
            // ChkSoldador
            // 
            this.ChkSoldador.AutoSize = true;
            this.ChkSoldador.Location = new System.Drawing.Point(6, 55);
            this.ChkSoldador.Name = "ChkSoldador";
            this.ChkSoldador.Size = new System.Drawing.Size(75, 19);
            this.ChkSoldador.TabIndex = 2;
            this.ChkSoldador.TabStop = true;
            this.ChkSoldador.Text = "Soldador";
            this.ChkSoldador.UseVisualStyleBackColor = true;
            // 
            // ChkMecanico
            // 
            this.ChkMecanico.AutoSize = true;
            this.ChkMecanico.Location = new System.Drawing.Point(7, 32);
            this.ChkMecanico.Name = "ChkMecanico";
            this.ChkMecanico.Size = new System.Drawing.Size(79, 19);
            this.ChkMecanico.TabIndex = 1;
            this.ChkMecanico.TabStop = true;
            this.ChkMecanico.Text = "Mecanico";
            this.ChkMecanico.UseVisualStyleBackColor = true;
            // 
            // ChkElectricista
            // 
            this.ChkElectricista.AutoSize = true;
            this.ChkElectricista.Location = new System.Drawing.Point(7, 9);
            this.ChkElectricista.Name = "ChkElectricista";
            this.ChkElectricista.Size = new System.Drawing.Size(84, 19);
            this.ChkElectricista.TabIndex = 0;
            this.ChkElectricista.TabStop = true;
            this.ChkElectricista.Text = "Electricista";
            this.ChkElectricista.UseVisualStyleBackColor = true;
            // 
            // errorProviderIdentificacion
            // 
            this.errorProviderIdentificacion.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "BIENVENIDO A CALCULADORA DE SALARIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "                       ¡ATENCION!\r\nTodos los espacios deben ser completados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculoSalariaForms.Properties.Resources.idea_light_bulb_icon_261867;
            this.pictureBox1.Location = new System.Drawing.Point(574, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCalcularSalario
            // 
            this.BtnCalcularSalario.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCalcularSalario.BackgroundImage = global::CalculoSalariaForms.Properties.Resources.preferencessystemlogin_93553;
            this.BtnCalcularSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCalcularSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcularSalario.Location = new System.Drawing.Point(301, 372);
            this.BtnCalcularSalario.Name = "BtnCalcularSalario";
            this.BtnCalcularSalario.Size = new System.Drawing.Size(182, 66);
            this.BtnCalcularSalario.TabIndex = 7;
            this.BtnCalcularSalario.Text = "CALCULAR SALARIO";
            this.BtnCalcularSalario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcularSalario.UseVisualStyleBackColor = false;
            this.BtnCalcularSalario.Click += new System.EventHandler(this.BtnCalcularSalario_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.BackgroundImage = global::CalculoSalariaForms.Properties.Resources.Go_back_36760;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSalir.Location = new System.Drawing.Point(547, 372);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(182, 66);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "VOLVER";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardarRegistro
            // 
            this.BtnGuardarRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGuardarRegistro.BackgroundImage = global::CalculoSalariaForms.Properties.Resources.Save_37110;
            this.BtnGuardarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardarRegistro.Location = new System.Drawing.Point(61, 372);
            this.BtnGuardarRegistro.Name = "BtnGuardarRegistro";
            this.BtnGuardarRegistro.Size = new System.Drawing.Size(182, 66);
            this.BtnGuardarRegistro.TabIndex = 5;
            this.BtnGuardarRegistro.Text = "GUARDAR REGISTRO";
            this.BtnGuardarRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarRegistro.UseVisualStyleBackColor = false;
            this.BtnGuardarRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculoSalarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GBOX1);
            this.Controls.Add(this.TxtDiasLaborados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCalcularSalario);
            this.Controls.Add(this.TxtSalarioDiaFalse);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardarRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIngresoIdentificacion);
            this.Controls.Add(this.TxtIngresoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbxGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculoSalarioForms";
            this.Text = "Calcular Salario";
            this.GBOX1.ResumeLayout(false);
            this.GBOX1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGuardarRegistro;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCalcularSalario;
        private System.Windows.Forms.ComboBox CmbxGenero;
        private System.Windows.Forms.TextBox TxtIngresoIdentificacion;
        private System.Windows.Forms.TextBox TxtIngresoNombre;
        private System.Windows.Forms.TextBox TxtDiasLaborados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSalarioDiaFalse;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox GBOX1;
        private System.Windows.Forms.ErrorProvider errorProviderIdentificacion;
        private System.Windows.Forms.RadioButton ChkAdministrativo;
        private System.Windows.Forms.RadioButton ChkServiciosGenerales;
        private System.Windows.Forms.RadioButton ChkSoldador;
        private System.Windows.Forms.RadioButton ChkMecanico;
        private System.Windows.Forms.RadioButton ChkElectricista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}