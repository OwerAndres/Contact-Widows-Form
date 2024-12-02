using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDContact;


namespace ContacWindows
{
    public partial class EliminarContacto : Form
    {
        public EliminarContacto()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayContact contactos = new ArrayContact();
            String nombre = textBox1.Text;
            string phone = textBox2.Text;
            contactos.eliminarUsuario(nombre, phone);
            pictureBox1.Show();
        }
    }
}


