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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            cmbDoc.Items.Add("DNI");
            cmbDoc.Items.Add("PAS");
            cmbDoc.Items.Add("CI");
            cmbDoc.Items.Add("LC");
            cmbDoc.Items.Add("LE");
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = cmbDoc.GetItemText(cmbDoc.SelectedItem);
            string nroDocumento = txtNumdedoc.Text;



            Usuario usu = new Usuario(cmbDoc.Text,txtNumdedoc.Text);

            string tipoCorrecto = "DNI";
            string docCorrecto = "40876140";

            if(cmbDoc.Text.Equals(tipoCorrecto) && txtNumdedoc.Text.Equals(docCorrecto))
            {   
                
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show(); 
                this.Hide();
            }
            else
            {
                //Nombre de usuario y password son incorrectos
                MessageBox.Show("No existe suscriptor, desea suscribirse", "Registro Suscriptor", MessageBoxButtons.OKCancel);
                    

            }
        }
    }
}
