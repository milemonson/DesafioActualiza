using ProyectoBase;
using Entidades; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)

        {
            LimpiarCampos();
            cmbEstado.Items.Add("Suscripto");
            cmbEstado.Items.Add("No suscripto");
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string resultado = "";

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string tipodeEstado = cmbEstado.GetItemText(cmbEstado.SelectedItem);

            bool tieneNombre = false;
            bool tieneApellido = false;
            bool tieneDireccion = false;
            bool tieneEmail = false;
            bool tieneTelefono = false;

            if (txtNombre.Text.Equals(" "))
            {
                MessageBox.Show("Ingrese Nombre");
                txtNombre.Focus();
            }
            else {
                tieneNombre = true;
            }
            if (txtApellido.Text.Equals(" "))
            {
                MessageBox.Show("Ingrese Apellido");
                txtApellido.Focus();
            }
            else
            {
                tieneApellido = true;
            }
            if (txtDireccion.Text.Equals(" "))
            {
                MessageBox.Show("Ingrese Direccion");
                txtDireccion.Focus();
            }
            else
            {
                tieneDireccion = true;
            }
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Email");
                txtEmail.Focus();
            }
            else
            {
                tieneEmail = true;
            }
            if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Telefono");
                txtTelefono.Focus();
            }
            else
            {
                tieneTelefono = true;
            }
            if (tieneNombre && tieneApellido && tieneDireccion && tieneEmail && tieneTelefono)
            {

                Suscriptor sus = new Suscriptor(nombre, apellido, direccion, email, telefono);

                AgregarSuscriptor(sus);
            }
         }

        private void AgregarSuscriptor(Suscriptor sus)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = sus.nombre;
            fila.Cells.Add(celdaNombre);
            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = sus.apellido;
            fila.Cells.Add(celdaApellido);
            DataGridViewTextBoxCell celdaDireccion = new DataGridViewTextBoxCell();
            celdaDireccion.Value = sus.direccion;
            fila.Cells.Add(celdaDireccion);
            DataGridViewTextBoxCell celdaEmail = new DataGridViewTextBoxCell();
            celdaEmail.Value = sus.email;
            fila.Cells.Add(celdaEmail);
            DataGridViewTextBoxCell celdaTelefono = new DataGridViewTextBoxCell();
            celdaTelefono.Value = sus.telefono;
            fila.Cells.Add(celdaTelefono);

            grdSuscriptor.Rows.Add(fila);
            MessageBox.Show("Suscriptor agregado");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }

}
