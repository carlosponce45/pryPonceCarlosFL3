using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPonceCarlosFL3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(object objUsuario)
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //registro
            StreamWriter sw = new StreamWriter("logGeneral", false);
            sw.WriteLine(" - Fecha: " + DateTime.Now);
            sw.Close();

            FrmRegistroProveedor v = new FrmRegistroProveedor();
            v.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = Convert.ToString(DateTime.Now);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmArchivos v = new FrmArchivos();
            v.ShowDialog();
        }
    }
}
