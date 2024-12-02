using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContacWindows;
using BDContact;

namespace ContacWindows
{
    public partial class InsertarContacto : Form
    {
        public InsertarContacto()
        {
            InitializeComponent();
            
        }

        // Método para actualizar el ListBox con los contactos actuales


        //Volver al inicio
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        //Añadir contacto
        private void button2_Click(object sender, EventArgs e)
        {
            ArrayContact arrayContac = new ArrayContact();
            Form1 Inicio = new Form1();

            String nombre = textBox1.Text;
            String phone = textBox2.Text;
            Boolean aux = false;

            if (phone == null || phone.Equals(""))
            {
                MessageBox.Show("ERROR: el número de teléfono no puede estar vacio.");
                aux = false;
            }else{
                if (phone.Length != 11)
                {
                    MessageBox.Show("ERROR: el número de teléfono debe tener 11 dígitos.");
                    aux = false;
                }
                else {
                    for (int i = 0; i < phone.Length; i++)
                    {
                        if (phone[i] < '0' || phone[i] > '9')
                        {
                            MessageBox.Show("ERROR: el número de teléfono debe tener solo números.");
                            aux = false;
                            break;
                            
                        }
                        else { aux = true; }
                    }
                }
            }

            if (aux)
            {
                Contact nuevoContacto = new Contact(nombre, phone);
                arrayContac.AñadirContacto(nuevoContacto);
                Inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR: Contacto no agregado");
            }
       
        }
    }
}
