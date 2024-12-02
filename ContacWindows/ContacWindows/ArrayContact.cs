using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContacWindows;

namespace BDContact
{

    internal class ArrayContact
    {
        // Lista estática para almacenar los contactos
        public static List<Contact> contactos = new List<Contact>();

        public void AñadirContacto(Contact contac)
        {
            contactos.Add(contac); // Agregar contacto a la lista estática
        }

        public String MostrarContacto()
        {
            //Manejar operaciones de manipulación de cadenas de texto de manera eficiente
            //En lugar de crear nuevas instancias de cadenas en cada operación, esta es Mutable
            StringBuilder cadena = new StringBuilder();
            foreach (var contacto in contactos)
            {
                //AppendLine Añade cada contacto en una nueva línea
                cadena.AppendLine(contacto.Name + " - " + contacto.Phone);
            }
            return cadena.ToString();
        }

        public void modifcarContacto(String nombre, String oldPhone, String phone)
        {

            bool encontrado = false;

            for (int i = 0; i < contactos.Count; i++)
            {
                if (contactos[i].Name == nombre && contactos[i].Phone == oldPhone)
                {
                    contactos[i].Phone = phone; 
                    MessageBox.Show("Teléfono actualizado con éxito");
                    encontrado = true; 
                    break; 
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("ERROR: Contacto no encontrado");
            }

        }
        public void eliminarUsuario(String nombre, String phone)
        {
            for(int i = 0;i < contactos.Count;i++)
            {
                if (contactos[i].Name.Equals(nombre) && contactos[i].Phone.Equals(phone))
                {
                    contactos.Remove(contactos[i]);
                    MessageBox.Show("contacto eliminado");
                }
                else
                {
                    MessageBox.Show("Contacto no encontrado");
                }
            }
        }
    }



}