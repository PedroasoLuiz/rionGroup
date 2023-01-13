namespace RION
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.panelUser.SuspendLayout();
            this.panelGeral.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelEndereco.SuspendLayout();
            this.panelContato.SuspendLayout();
            this.panelColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 198);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(29, 261);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(176, 198);
            // 
            // tbColaborador
            // 
            this.tbColaborador.Location = new System.Drawing.Point(33, 374);
            this.tbColaborador.CheckedChanged += new System.EventHandler(this.tbColaborador_CheckedChanged_1);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(85, 377);
            // 
            // btnSenha
            // 
            this.btnSenha.FlatAppearance.BorderSize = 0;
            this.btnSenha.Location = new System.Drawing.Point(30, 1357);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.Text = "Nome completo:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 135);
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.Text = "Nome abreviado:";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(171)))), ((int)(((byte)(199)))));
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            // 
            // panelGeral
            // 
            this.panelGeral.Controls.Add(this.panel3);
            this.panelGeral.Controls.SetChildIndex(this.label15, 0);
            this.panelGeral.Controls.SetChildIndex(this.panelInfo, 0);
            this.panelGeral.Controls.SetChildIndex(this.panelColaborador, 0);
            this.panelGeral.Controls.SetChildIndex(this.panelContato, 0);
            this.panelGeral.Controls.SetChildIndex(this.panelEndereco, 0);
            this.panelGeral.Controls.SetChildIndex(this.btnSenha, 0);
            this.panelGeral.Controls.SetChildIndex(this.panel3, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.Text = "Clientes";
            // 
            // label15
            // 
            this.label15.Size = new System.Drawing.Size(556, 38);
            // 
            // label17
            // 
            this.label17.Size = new System.Drawing.Size(556, 38);
            // 
            // label16
            // 
            this.label16.Size = new System.Drawing.Size(556, 38);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.label31);
            this.panelInfo.Controls.Add(this.rjTextBox5);
            this.panelInfo.Size = new System.Drawing.Size(556, 401);
            this.panelInfo.Controls.SetChildIndex(this.txtSobrenome, 0);
            this.panelInfo.Controls.SetChildIndex(this.tbColaborador, 0);
            this.panelInfo.Controls.SetChildIndex(this.txtNasc, 0);
            this.panelInfo.Controls.SetChildIndex(this.txtId, 0);
            this.panelInfo.Controls.SetChildIndex(this.txtIdade, 0);
            this.panelInfo.Controls.SetChildIndex(this.label2, 0);
            this.panelInfo.Controls.SetChildIndex(this.txtCPF, 0);
            this.panelInfo.Controls.SetChildIndex(this.label8, 0);
            this.panelInfo.Controls.SetChildIndex(this.label9, 0);
            this.panelInfo.Controls.SetChildIndex(this.label11, 0);
            this.panelInfo.Controls.SetChildIndex(this.label7, 0);
            this.panelInfo.Controls.SetChildIndex(this.label3, 0);
            this.panelInfo.Controls.SetChildIndex(this.label6, 0);
            this.panelInfo.Controls.SetChildIndex(this.txtNome, 0);
            this.panelInfo.Controls.SetChildIndex(this.rjTextBox5, 0);
            this.panelInfo.Controls.SetChildIndex(this.label31, 0);
            // 
            // panelEndereco
            // 
            this.panelEndereco.Location = new System.Drawing.Point(0, 784);
            this.panelEndereco.Size = new System.Drawing.Size(556, 318);
            // 
            // panelContato
            // 
            this.panelContato.Controls.Add(this.label26);
            this.panelContato.Controls.Add(this.rjTextBox1);
            this.panelContato.Location = new System.Drawing.Point(0, 517);
            this.panelContato.Size = new System.Drawing.Size(556, 267);
            this.panelContato.Controls.SetChildIndex(this.label16, 0);
            this.panelContato.Controls.SetChildIndex(this.rjTextBox1, 0);
            this.panelContato.Controls.SetChildIndex(this.label26, 0);
            // 
            // panelColaborador
            // 
            this.panelColaborador.Location = new System.Drawing.Point(0, 439);
            // 
            // btnUpload
            // 
            this.btnUpload.FlatAppearance.BorderSize = 0;
            // 
            // label25
            // 
            this.label25.Size = new System.Drawing.Size(103, 16);
            this.label25.Text = "Cadastrado por:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Texts = "PEDRO AUGUSTO";
            // 
            // txtNome
            // 
            this.txtNome.Size = new System.Drawing.Size(479, 34);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(33, 152);
            this.txtSobrenome.Size = new System.Drawing.Size(479, 34);
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(32, 215);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(32, 278);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(179, 215);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.rjTextBox4);
            this.panel3.Controls.Add(this.rjComboBox1);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.rjTextBox3);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.rjTextBox2);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 1102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 229);
            this.panel3.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.Location = new System.Drawing.Point(164, 111);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 15);
            this.label30.TabIndex = 16;
            this.label30.Text = "Conta:";
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjTextBox4.BorderRadius = 5;
            this.rjTextBox4.BorderSize = 1;
            this.rjTextBox4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(167, 128);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 5, 2, 10);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(142, 34);
            this.rjTextBox4.TabIndex = 15;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjComboBox1.BorderSize = 0;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold);
            this.rjComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(38, 71);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 12;
            this.rjComboBox1.Texts = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(30, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 15);
            this.label29.TabIndex = 13;
            this.label29.Text = "Banco:";
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjTextBox3.BorderRadius = 5;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(33, 68);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 5, 2, 10);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(210, 34);
            this.rjTextBox3.TabIndex = 14;
            this.rjTextBox3.Texts = "1";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label28.Location = new System.Drawing.Point(30, 111);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 15);
            this.label28.TabIndex = 11;
            this.label28.Text = "Agência:";
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjTextBox2.BorderRadius = 5;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(33, 128);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 5, 2, 10);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(116, 34);
            this.rjTextBox2.TabIndex = 10;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.label27.Size = new System.Drawing.Size(556, 38);
            this.label27.TabIndex = 1;
            this.label27.Text = "Dados bancários:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(213, 177);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 15);
            this.label26.TabIndex = 9;
            this.label26.Text = "Contato:";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjTextBox1.BorderRadius = 5;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(216, 194);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 5, 2, 10);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(162, 34);
            this.rjTextBox1.TabIndex = 8;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(191, 261);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 15);
            this.label31.TabIndex = 18;
            this.label31.Text = "Inscrição Estadual:";
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rjTextBox5.BorderRadius = 5;
            this.rjTextBox5.BorderSize = 1;
            this.rjTextBox5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(194, 278);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(10, 5, 2, 10);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(148, 34);
            this.rjTextBox5.TabIndex = 17;
            this.rjTextBox5.Texts = "";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 681);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelGeral.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelEndereco.ResumeLayout(false);
            this.panelEndereco.PerformLayout();
            this.panelContato.ResumeLayout(false);
            this.panelContato.PerformLayout();
            this.panelColaborador.ResumeLayout(false);
            this.panelColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label26;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label28;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        protected internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        protected System.Windows.Forms.Label label29;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label31;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
    }
}