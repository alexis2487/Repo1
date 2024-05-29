using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();

        }
        // Metodo pata diseñar la interfaz grafica del arbol
        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diseño del nodo raiz
            Graphics Nodo;
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Cyan, 320, 30, 35, 35);
            Nodo.DrawString("50", Font, Brushes.Purple, 330, 40);
            Pen MyNodoRaiz = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(MyNodoRaiz, 320, 30, 35, 35);

            //______________________________________________________________________________________
            //Rama Raiz Nodo Izquierdo 

            // Diseño Nodo Padre (40)
            Nodo.FillEllipse(Brushes.Cyan, 200, 80, 35, 35);
            Nodo.DrawString("40", Font, Brushes.Purple, 210, 90);
            Pen Nodo1 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo1, 200, 80, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea1 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea1, 235, 90, 320, 55);


            // Diseño Nodo Padre (30)
            Nodo.FillEllipse(Brushes.Cyan, 130, 150, 35, 35);
            Nodo.DrawString("30", Font, Brushes.Purple, 140, 160);
            Pen Nodo3 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo3, 130, 150, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea3 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea3, 205, 111, 161, 154);

            //  Diseño Nodo Hoja (25)
            Nodo.FillEllipse(Brushes.Cyan, 80, 220, 35, 35);
            Nodo.DrawString("25", Font, Brushes.Purple, 90, 230);
            Pen Nodo5 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo5, 80, 220, 35, 35);

            // Linea para conectar los nodos pendiente
            Pen MyLinea5 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea5, 136, 183, 109, 222);

            //  Diseño Nodo Hoja (35)
            Nodo.FillEllipse(Brushes.Cyan, 190, 220, 35, 35);
            Nodo.DrawString("35", Font, Brushes.Purple, 200, 230);
            Pen Nodo6 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo6, 190, 220, 35, 35);

            // Linea para conectar los nodos pendiente
            Pen MyLinea6 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea6, 160, 181, 197, 223);

            //  Diseño Nodo Rama (45)
            Nodo.FillEllipse(Brushes.Cyan, 270, 150, 35, 35);
            Nodo.DrawString("45", Font, Brushes.Purple, 280, 160);
            Pen Nodo4 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo4, 270, 150, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea4 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea4, 230, 112, 275, 153);

            //  Diseño Nodo Hoja (42)
            Nodo.FillEllipse(Brushes.Cyan, 230, 220, 35, 35);
            Nodo.DrawString("42", Font, Brushes.Purple, 240, 230);
            Pen Nodo7 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo7, 230, 220, 35, 35);

            // Linea para conectar los nodos pendiente
            Pen MyLinea7 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea7, 277, 183, 258, 222);

            //______________________________________________________________________________________
            //Rama Raiz Nodo Derecho

            ////  Diseño Nodo Padre (60)
            Nodo.FillEllipse(Brushes.Cyan, 440, 80, 35, 35);
            Nodo.DrawString("60", Font, Brushes.Purple, 450, 90);
            Pen Nodo2 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo2, 440, 80, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea2 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea2, 355, 55, 440, 90);

            //  Diseño Nodo Hoja (55)
            Nodo.FillEllipse(Brushes.Cyan, 390, 150, 35, 35);
            Nodo.DrawString("55", Font, Brushes.Purple, 400, 160);
            Pen Nodo8 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo8, 390, 150, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea8 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea8, 446, 112, 417, 152);

            //  Diseño Nodo Padre (70)
            Nodo.FillEllipse(Brushes.Cyan, 500, 150, 35, 35);
            Nodo.DrawString("70", Font, Brushes.Purple, 510, 160);
            Pen Nodo9 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo9, 500, 150, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea9 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea9, 471, 112, 508, 152);

            //  Diseño Nodo Hoja (65)
            Nodo.FillEllipse(Brushes.Cyan, 450, 220, 35, 35);
            Nodo.DrawString("65", Font, Brushes.Purple, 460, 230);
            Pen Nodo10 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo10, 450, 220, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea10 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea10, 505, 181, 475, 220);

            //  Diseño Nodo Hoja (75)
            Nodo.FillEllipse(Brushes.Cyan, 560, 220, 35, 35);
            Nodo.DrawString("75", Font, Brushes.Purple, 570, 230);
            Pen Nodo11 = new Pen(Color.Orange, 3);
            Nodo.DrawEllipse(Nodo11, 560, 220, 35, 35);

            // Linea para conectar los nodos
            Pen MyLinea11 = new Pen(Color.Orange, 2);
            Nodo.DrawLine(MyLinea11, 530, 182, 567, 220);

  
            textBoxInformacion.Text = "Altura = 4";
            textBoxNivel.Text = "Nivel = 4";
            textBoxPeso.Text = "Peso = 12";

        }



        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Metodo para graficar el recorrido en pre orden
            Graphics PreOrden;
            PreOrden = CreateGraphics();
            PreOrden.DrawString("Pre Orden:", Font, Brushes.Red, 30, 280);

            Pen MyPreOrden = new Pen(Color.Green, 1);
            PreOrden.DrawEllipse(MyPreOrden, 90, 270, 35, 35);
            PreOrden.DrawString("50", Font, Brushes.Purple, 100, 280);

            PreOrden.DrawEllipse(MyPreOrden, 130, 270, 35, 35);
            PreOrden.DrawString("40", Font, Brushes.Purple, 140, 280);

            PreOrden.DrawEllipse(MyPreOrden, 170, 270, 35, 35);
            PreOrden.DrawString("30", Font, Brushes.Purple, 180, 280);

            PreOrden.DrawEllipse(MyPreOrden, 210, 270, 35, 35);
            PreOrden.DrawString("25", Font, Brushes.Purple, 220, 280);

            PreOrden.DrawEllipse(MyPreOrden, 250, 270, 35, 35);
            PreOrden.DrawString("35", Font, Brushes.Purple, 260, 280);

            PreOrden.DrawEllipse(MyPreOrden, 290, 270, 35, 35);
            PreOrden.DrawString("45", Font, Brushes.Purple, 300, 280);

            PreOrden.DrawEllipse(MyPreOrden, 330, 270, 35, 35);
            PreOrden.DrawString("42", Font, Brushes.Purple, 340, 280);

            PreOrden.DrawEllipse(MyPreOrden, 370, 270, 35, 35);
            PreOrden.DrawString("60", Font, Brushes.Purple, 380, 280);

            PreOrden.DrawEllipse(MyPreOrden, 410, 270, 35, 35);
            PreOrden.DrawString("55", Font, Brushes.Purple, 420, 280);

            PreOrden.DrawEllipse(MyPreOrden, 450, 270, 35, 35);
            PreOrden.DrawString("70", Font, Brushes.Purple, 460, 280);

            PreOrden.DrawEllipse(MyPreOrden, 490, 270, 35, 35);
            PreOrden.DrawString("65", Font, Brushes.Purple, 500, 280);

            PreOrden.DrawEllipse(MyPreOrden, 530, 270, 35, 35);
            PreOrden.DrawString("75", Font, Brushes.Purple, 540, 280);



        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Metodo para graficar el recorrido en In orden
            Graphics InOrden;
            InOrden = CreateGraphics();
            InOrden.DrawString("In Orden:", Font, Brushes.Red, 30, 330);

            Pen MyInOrden = new Pen(Color.Green, 1);
            InOrden.DrawEllipse(MyInOrden, 90, 320, 35, 35);
            InOrden.DrawString("25", Font, Brushes.Purple, 100, 330);

            InOrden.DrawEllipse(MyInOrden, 130, 320, 35, 35);
            InOrden.DrawString("30", Font, Brushes.Purple, 140, 330);

            InOrden.DrawEllipse(MyInOrden, 170, 320, 35, 35);
            InOrden.DrawString("35", Font, Brushes.Purple, 180, 330);

            InOrden.DrawEllipse(MyInOrden, 210, 320, 35, 35);
            InOrden.DrawString("40", Font, Brushes.Purple, 220, 330);

            InOrden.DrawEllipse(MyInOrden, 250, 320, 35, 35);
            InOrden.DrawString("42", Font, Brushes.Purple, 260, 330);

            InOrden.DrawEllipse(MyInOrden, 290, 320, 35, 35);
            InOrden.DrawString("45", Font, Brushes.Purple, 300, 330);

            InOrden.DrawEllipse(MyInOrden, 330, 320, 35, 35);
            InOrden.DrawString("50", Font, Brushes.Purple, 340, 330);

            InOrden.DrawEllipse(MyInOrden, 370, 320, 35, 35);
            InOrden.DrawString("55", Font, Brushes.Purple, 380, 330);

            InOrden.DrawEllipse(MyInOrden, 410, 320, 35, 35);
            InOrden.DrawString("60", Font, Brushes.Purple, 420, 330);

            InOrden.DrawEllipse(MyInOrden, 450, 320, 35, 35);
            InOrden.DrawString("65", Font, Brushes.Purple, 460, 330);

            InOrden.DrawEllipse(MyInOrden, 490, 320, 35, 35);
            InOrden.DrawString("70", Font, Brushes.Purple, 500, 330);

            InOrden.DrawEllipse(MyInOrden, 530, 320, 35, 35);
            InOrden.DrawString("75", Font, Brushes.Purple, 540, 330);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Metodo para graficar el recorrido en Post orden
            Graphics PostOrden;
            PostOrden = CreateGraphics();
            PostOrden.DrawString("Post Orden:", Font, Brushes.Red, 25, 380);

            Pen MyPostOrden = new Pen(Color.Green, 1);
            PostOrden.DrawEllipse(MyPostOrden, 90, 370, 35, 35);
            PostOrden.DrawString("25", Font, Brushes.Purple, 100, 380);

            PostOrden.DrawEllipse(MyPostOrden, 130, 370, 35, 35);
            PostOrden.DrawString("35", Font, Brushes.Purple, 140, 380);

            PostOrden.DrawEllipse(MyPostOrden, 170, 370, 35, 35);
            PostOrden.DrawString("30", Font, Brushes.Purple, 180, 380);

            PostOrden.DrawEllipse(MyPostOrden, 210, 370, 35, 35);
            PostOrden.DrawString("42", Font, Brushes.Purple, 220, 380);

            PostOrden.DrawEllipse(MyPostOrden, 250, 370, 35, 35);
            PostOrden.DrawString("45", Font, Brushes.Purple, 260, 380);

            PostOrden.DrawEllipse(MyPostOrden, 290, 370, 35, 35);
            PostOrden.DrawString("40", Font, Brushes.Purple, 300, 380);

            PostOrden.DrawEllipse(MyPostOrden, 330, 370, 35, 35);
            PostOrden.DrawString("55", Font, Brushes.Purple, 340, 380);

            PostOrden.DrawEllipse(MyPostOrden, 370, 370, 35, 35);
            PostOrden.DrawString("65", Font, Brushes.Purple, 380, 380);

            PostOrden.DrawEllipse(MyPostOrden, 410, 370, 35, 35);
            PostOrden.DrawString("75", Font, Brushes.Purple, 420, 380);

            PostOrden.DrawEllipse(MyPostOrden, 450, 370, 35, 35);
            PostOrden.DrawString("70", Font, Brushes.Purple, 460, 380);

            PostOrden.DrawEllipse(MyPostOrden, 490, 370, 35, 35);
            PostOrden.DrawString("60", Font, Brushes.Purple, 500, 380);

            PostOrden.DrawEllipse(MyPostOrden, 530, 370, 35, 35);
            PostOrden.DrawString("50", Font, Brushes.Purple, 540, 380);
        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu formmenu = new Menu();
            formmenu.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
