namespace CalculoSalariaForms
{
    partial class FormsInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIngresoClave = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnValidarIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE CLAVE";
            // 
            // TxtIngresoClave
            // 
            this.TxtIngresoClave.Location = new System.Drawing.Point(553, 137);
            this.TxtIngresoClave.Name = "TxtIngresoClave";
            this.TxtIngresoClave.PasswordChar = '*';
            this.TxtIngresoClave.Size = new System.Drawing.Size(169, 20);
            this.TxtIngresoClave.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.label2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(210, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "ESTRUCTURA DE DATOS\r\nJair Alexis Martinez\r\nIngenieria De Sistemas\r\n1121927224\r\nAu" +
    "toria Propia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "             ¡ATENCION!\r\nLa clave debe ser numerica";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CalculoSalariaForms.Properties.Resources.idea_light_bulb_icon_261867;
            this.pictureBox3.Location = new System.Drawing.Point(625, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::CalculoSalariaForms.Properties.Resources.talk_speech_chat_message_comment_communication_conversation_bubble_icon_260633;
            this.pictureBox2.Location = new System.Drawing.Point(162, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CalculoSalariaForms.Properties.Resources.avatar_person_boy_male_people_guy_character_user_profile_young_man_work_west_shirt_short_hair_clothes_glasses_icon_262226;
            this.pictureBox1.Location = new System.Drawing.Point(1, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::CalculoSalariaForms.Properties.Resources.action_exit_close_remove_13915;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(621, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "SALIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnValidarIngreso
            // 
            this.BtnValidarIngreso.BackColor = System.Drawing.SystemColors.Control;
            this.BtnValidarIngreso.BackgroundImage = global::CalculoSalariaForms.Properties.Resources.preferencessystemlogin_93553;
            this.BtnValidarIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnValidarIngreso.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnValidarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorProvider1.SetIconAlignment(this.BtnValidarIngreso, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.BtnValidarIngreso.Location = new System.Drawing.Point(408, 286);
            this.BtnValidarIngreso.Name = "BtnValidarIngreso";
            this.BtnValidarIngreso.Size = new System.Drawing.Size(187, 78);
            this.BtnValidarIngreso.TabIndex = 2;
            this.BtnValidarIngreso.Text = "INGRESAR";
            this.BtnValidarIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnValidarIngreso.UseVisualStyleBackColor = false;
            this.BtnValidarIngreso.Click += new System.EventHandler(this.BtnValidarIngreso_Click);
            // 
            // FormsInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(838, 376);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnValidarIngreso);
            this.Controls.Add(this.TxtIngresoClave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormsInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIngresoClave;
        private System.Windows.Forms.Button BtnValidarIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

