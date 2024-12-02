using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContacWindows
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        //Buscar contacto
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 BuscarContacto = new Form2();
            BuscarContacto.Show();
            this.Hide();

        }

        //Insertar contacto
        private void button2_Click(object sender, EventArgs e)
        {
            InsertarContacto insertarContacto = new InsertarContacto();
            insertarContacto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 actulizarContacto = new Form3();
            actulizarContacto.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarContacto eliminarContact = new EliminarContacto();
            eliminarContact.Show();
            this.Hide();
        }
    }
}
