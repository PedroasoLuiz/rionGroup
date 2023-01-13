using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RION
{
    public partial class FrmUsuários : Form
    {
        public FrmUsuários()
        {
            InitializeComponent();
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuários_Load(object sender, EventArgs e)
        {
             
        }

        private void tbColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (tbColaborador.Checked == false)
                panelColaborador.Visible = false;
            else
                panelColaborador.Visible = true;
        }
    }
}
