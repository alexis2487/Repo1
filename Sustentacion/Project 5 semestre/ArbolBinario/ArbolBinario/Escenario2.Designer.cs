namespace ArbolBinario
{
    partial class Escenario2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxInformacion = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.volverToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficaToolStripMenuItem
            // 
            this.graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            this.graficaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graficaToolStripMenuItem.Text = "Grafica";
            this.graficaToolStripMenuItem.Click += new System.EventHandler(this.graficaToolStripMenuItem_Click);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preOrdenToolStripMenuItem,
            this.inOrdenToolStripMenuItem,
            this.postOrdenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            this.preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            this.preOrdenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.preOrdenToolStripMenuItem.Text = "Pre Orden";
            this.preOrdenToolStripMenuItem.Click += new System.EventHandler(this.preOrdenToolStripMenuItem_Click);
            // 
            // inOrdenToolStripMenuItem
            // 
            this.inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            this.inOrdenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.inOrdenToolStripMenuItem.Text = "In Orden";
            this.inOrdenToolStripMenuItem.Click += new System.EventHandler(this.inOrdenToolStripMenuItem_Click);
            // 
            // postOrdenToolStripMenuItem
            // 
            this.postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            this.postOrdenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.postOrdenToolStripMenuItem.Text = "Post Orden";
            this.postOrdenToolStripMenuItem.Click += new System.EventHandler(this.postOrdenToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Enabled = false;
            this.textBoxPeso.Location = new System.Drawing.Point(659, 79);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(115, 20);
            this.textBoxPeso.TabIndex = 10;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Enabled = false;
            this.textBoxNivel.Location = new System.Drawing.Point(659, 53);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(115, 20);
            this.textBoxNivel.TabIndex = 9;
            // 
            // textBoxInformacion
            // 
            this.textBoxInformacion.Enabled = false;
            this.textBoxInformacion.Location = new System.Drawing.Point(659, 27);
            this.textBoxInformacion.Name = "textBoxInformacion";
            this.textBoxInformacion.Size = new System.Drawing.Size(115, 20);
            this.textBoxInformacion.TabIndex = 8;
            // 
            // Escenario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxNivel);
            this.Controls.Add(this.textBoxInformacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Escenario2";
            this.Text = "Escenario2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOrdenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textBoxInformacion;
    }
}