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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String numViejo = textBox2.Text;
            String newNum = textBox3.Text;
            ArrayContact contact = new ArrayContact();
            contact.modifcarContacto(nombre, numViejo, newNum);
        }
    }
}
