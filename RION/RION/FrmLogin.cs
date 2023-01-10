using CustomControls.RJControls;
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
    public partial class FrmLogin :Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Botão fechar formulário
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmContainer frm = new FrmContainer();
            frm.lnUsername.Text = txtEmail.Texts;
            //this.Hide(); // use dessa maneira.
            frm.ShowDialog();
        }




        /* LINKS DE REDIRECIONAMENTO */
        /*--------------------------------------------------------------
         * -------------------------------------------------------------*/


        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabCadastro;
                txtEmail.Texts = string.Empty;
                txtSenha.Texts = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*---------------------------------------------------------------------------------------------*/
        // Exibe a senha na guia Login
        private void verSenha_MouseHover(object sender, EventArgs e)
        {
            try
            { MostraSenha(txtSenha); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        // Oculta novamente a senha na guia login
        private void verSenha_MouseLeave(object sender, EventArgs e)
        {
            try
            { OcultaSenha(txtSenha); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        /*---------------------------------------------------------------------------------------------*/
        // Exibe a senha na guia Cadastro
        private void verSenha_Cadastro_MouseHover(object sender, EventArgs e)
        {
            try
            { MostraSenha(txtSenha_Cadastro); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        // Oculta novamente a senha na guia cadastro
        private void verSenha_Cadastro_MouseLeave(object sender, EventArgs e)
        {
            try
            { OcultaSenha(txtSenha_Cadastro); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        /*---------------------------------------------------------------------------------------------*/
        //Exibe a senha de confirmação na guia Cadatsro
        private void versenha2_Cadastro_MouseHover(object sender, EventArgs e)
        {
            try
            { MostraSenha(txtConfSenha_Cadastro); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        // Oculta novamente a senha da confirmação na guia cadastro
        private void versenha2_Cadastro_MouseLeave(object sender, EventArgs e)
        {
            try
            { OcultaSenha(txtConfSenha_Cadastro); }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        /*---------------------------------------------------------------------------------------------*/




        /* MÉTODOS UTILIZAVEIS
         * ----------------------------------------------
         * */
        private void MostraSenha(RJTextBox txt)
        { txt.PasswordChar = false; }

        private void OcultaSenha(RJTextBox txt)
        { txt.PasswordChar = true; }

    }
}
