namespace ArbolBinario
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
            this.buttonEscenario1 = new System.Windows.Forms.Button();
            this.buttonEscenario2 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEscenario1
            // 
            this.buttonEscenario1.Location = new System.Drawing.Point(363, 101);
            this.buttonEscenario1.Name = "buttonEscenario1";
            this.buttonEscenario1.Size = new System.Drawing.Size(75, 23);
            this.buttonEscenario1.TabIndex = 0;
            this.buttonEscenario1.Text = "Escenario 1";
            this.buttonEscenario1.UseVisualStyleBackColor = true;
            this.buttonEscenario1.Click += new System.EventHandler(this.buttonEscenario1_Click);
            // 
            // buttonEscenario2
            // 
            this.buttonEscenario2.Location = new System.Drawing.Point(363, 174);
            this.buttonEscenario2.Name = "buttonEscenario2";
            this.buttonEscenario2.Size = new System.Drawing.Size(75, 23);
            this.buttonEscenario2.TabIndex = 1;
            this.buttonEscenario2.Text = "Escenario 2";
            this.buttonEscenario2.UseVisualStyleBackColor = true;
            this.buttonEscenario2.Click += new System.EventHandler(this.buttonEscenario2_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(658, 371);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEscenario2);
            this.Controls.Add(this.buttonEscenario1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEscenario1;
        private System.Windows.Forms.Button buttonEscenario2;
        private System.Windows.Forms.Button buttonSalir;
    }
}