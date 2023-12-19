using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace pryPonceCarlosFL3
{
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex != -1)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                cboRol.Enabled = true;
            }
            else
            {
                cboRol.Enabled = false;
            }
        }

        private void pbFirma_Click(object sender, EventArgs e)
        {

        }
        private byte[] ConvertPictureBoxToBytes(PictureBox pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Convierte la imagen en el PictureBox en un formato de imagen
                pictureBox.Image.Save(memoryStream, ImageFormat.Png);

                // Obtiene los bytes de la imagen
                return memoryStream.ToArray();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string NuevoUsuario = txtUsuario.Text;
            string NuevaContraseña = txtPassword.Text;
            string Rol = cboRol.Text;

            clsUsuario objUsuario = new clsUsuario();
            objUsuario.RegistrarLogs(NuevoUsuario, NuevaContraseña, Rol);
            FrmRegistro Inicio = new FrmRegistro();
            Inicio.ShowDialog();
            this.Hide();
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
