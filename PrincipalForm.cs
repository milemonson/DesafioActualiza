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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenid@ " + usu.numerodedoc;
            lblBienvenida.Visible = true;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //Nombre de usuario y password son correctos
               Modificar ventana = new Modificar();
                ventana.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //Nombre de usuario y password son correctos
                Loginform ventana = new Loginform();
                ventana.Show();
                this.Hide();
            }
        }
    }
}
