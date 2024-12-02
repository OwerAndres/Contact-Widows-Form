using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContacWindows;
using BDContact;

namespace ContacWindows
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArrayContact listaContactos = new ArrayContact();
            string contactos = listaContactos.MostrarContacto();
            string[] lineas = contactos.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linea in lineas)
            {
                listBox1.Items.Add(linea);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String telefono = textBox1.Text;
            Boolean aux = false;
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().Contains(telefono))  // Cambié la comparación para buscar parte del nombre o teléfono
                {
                    MessageBox.Show("Contacto encontrado: \n" + item);
                    aux = true;
                    break;
                }
            }
            if (!aux)
            {
                MessageBox.Show("Contacto no encontrado");
            }
        }
    }
}

