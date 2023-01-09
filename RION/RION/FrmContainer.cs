using MetroFramework.Forms;
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
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            try
            {
                FechaOpcoes(panelAlmoxarifado);
                Opcoes(panelCadastros);
                FechaOpcoes(panelEngenharia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEngenharia_Click(object sender, EventArgs e)
        {
            try
            {
                FechaOpcoes(panelAlmoxarifado);
                FechaOpcoes(panelCadastros);
                Opcoes(panelEngenharia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlmoxarifado_Click(object sender, EventArgs e)
        {
            try
            {
                Opcoes(panelAlmoxarifado);
                FechaOpcoes(panelCadastros);
                FechaOpcoes(panelEngenharia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Opcoes(Panel container)
        {
            try
            {
                if (container.Visible == true)
                    container.Visible = false;
                else
                    container.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FechaOpcoes(Panel container)
        {
            container.Visible = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
