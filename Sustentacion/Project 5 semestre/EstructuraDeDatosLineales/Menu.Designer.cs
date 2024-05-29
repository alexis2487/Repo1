namespace EstructuraDeDatosLineales
{
    partial class Menu
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
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonCola = new System.Windows.Forms.Button();
            this.buttonPila = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.Black;
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonList.Location = new System.Drawing.Point(572, 209);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(194, 78);
            this.buttonList.TabIndex = 5;
            this.buttonList.Text = "list";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonCola
            // 
            this.buttonCola.BackColor = System.Drawing.Color.Blue;
            this.buttonCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCola.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCola.Location = new System.Drawing.Point(570, 116);
            this.buttonCola.Name = "buttonCola";
            this.buttonCola.Size = new System.Drawing.Size(194, 78);
            this.buttonCola.TabIndex = 4;
            this.buttonCola.Text = "cola";
            this.buttonCola.UseVisualStyleBackColor = false;
            this.buttonCola.Click += new System.EventHandler(this.buttonCola_Click);
            // 
            // buttonPila
            // 
            this.buttonPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPila.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPila.Location = new System.Drawing.Point(570, 21);
            this.buttonPila.Name = "buttonPila";
            this.buttonPila.Size = new System.Drawing.Size(196, 78);
            this.buttonPila.TabIndex = 3;
            this.buttonPila.Text = "pila";
            this.buttonPila.UseVisualStyleBackColor = false;
            this.buttonPila.Click += new System.EventHandler(this.buttonPila_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(649, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuraDeDatosLineales.Properties.Resources.avatar_person_boy_male_;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EstructuraDeDatosLineales.Properties.Resources.dialoguebubble_4874;
            this.pictureBox2.Location = new System.Drawing.Point(214, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "   Bienvenido A Mi Proyecto \r\nEn Este Menu Podras Escoger\r\n     Entre Pila,Cola y" +
    " List ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonCola);
            this.Controls.Add(this.buttonPila);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonCola;
        private System.Windows.Forms.Button buttonPila;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}