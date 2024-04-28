using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = tboxApellido.Text.ToUpper();
            string nombre = tboxNombre.Text.ToUpper();
            int edad;
            string direccion = tboxDireccion.Text.ToUpper();

            List<string> errores = new List<string>();

            if (string.IsNullOrEmpty(apellido))
            {
                tboxApellido.BackColor = Color.Red;
                tboxApellido.Focus();
                errores.Add(apellido);
            }
            else if (apellido.Length > 30 || apellido.Length < 2)
            {
                tboxApellido.BackColor = Color.Red;
                tboxApellido.Focus();
                MessageBox.Show("Debe tener entre 2 y 30 caracteres");
                errores.Add(apellido);

            }
            else
            {
                errores.Remove(apellido);
                tboxApellido.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                tboxNombre.BackColor = Color.Red;
                tboxNombre.Focus();
                errores.Add((nombre));
            }
            else if (nombre.Length > 30 || nombre.Length < 2)
            {
                tboxNombre.BackColor = Color.Red;
                tboxNombre.Focus();
                MessageBox.Show("Debe tener entre 2 y 30 caracteres");
                errores.Add((nombre));

            }
            else
            {
                errores.Remove((nombre));
                tboxNombre.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(tboxEdad.Text))
            {
                tboxEdad.BackColor = Color.Red;
                tboxEdad.Focus();
                errores.Add(tboxEdad.Text);
            }
            else if (!int.TryParse(tboxEdad.Text, out edad))
            {
                MessageBox.Show("Por favor ingrese una edad válida");
                errores.Add(tboxEdad.Text);
                tboxEdad.Focus();
                return;
            } else
            {
                errores.Remove(tboxEdad.Text);
                tboxEdad.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(direccion))
            {
                tboxDireccion.BackColor = Color.Red;
                tboxDireccion.Focus();
                errores.Add(direccion);
            }
            else if (direccion.Length > 50 || direccion.Length < 10)
            {
                tboxDireccion.BackColor = Color.Red;
                tboxDireccion.Focus();
                MessageBox.Show("Debe tener entre 10 y 50 caracteres");
                errores.Add(direccion);

            }
            else 
            {
                errores.Remove(direccion);
                tboxDireccion.BackColor = SystemColors.Window; 
            }

            if (errores.Count != 0) 
            { 
                listBoxResultado.Items.Clear();
            }else
            {
                listBoxResultado.Items.Add("Nombre y apellido : " + nombre + " " + apellido);
                listBoxResultado.Items.Add("Edad: " + tboxEdad.Text);
                listBoxResultado.Items.Add("Dirección: " + direccion);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
