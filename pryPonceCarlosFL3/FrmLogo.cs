using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonceCarlosFL3
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
        }
        int contadorTiempo = 0;
        private void temporizador_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if (contadorTiempo > 3000)
            {
                this.Hide();
               FrmRegistro formularioPrincipal = new FrmRegistro();
                formularioPrincipal.Show();
                temporizador.Enabled = false;
            }
;
        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {

        }
    }
}
