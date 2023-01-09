namespace RION
{
    partial class FrmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCadastros = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelEngenharia = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelAlmoxarifado = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnSair = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlmoxarifado = new System.Windows.Forms.Button();
            this.btnEngenharia = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCadastros.SuspendLayout();
            this.panelEngenharia.SuspendLayout();
            this.panelAlmoxarifado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panelAlmoxarifado);
            this.panel1.Controls.Add(this.btnAlmoxarifado);
            this.panel1.Controls.Add(this.panelEngenharia);
            this.panel1.Controls.Add(this.btnEngenharia);
            this.panel1.Controls.Add(this.panelCadastros);
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjCircularPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lnUsername);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 208);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(44, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "•";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ativo";
            // 
            // lnUsername
            // 
            this.lnUsername.AutoSize = true;
            this.lnUsername.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnUsername.ForeColor = System.Drawing.Color.White;
            this.lnUsername.Location = new System.Drawing.Point(44, 139);
            this.lnUsername.Name = "lnUsername";
            this.lnUsername.Size = new System.Drawing.Size(105, 16);
            this.lnUsername.TabIndex = 1;
            this.lnUsername.Text = "<nome usuário>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 36);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panelCadastros
            // 
            this.panelCadastros.Controls.Add(this.button4);
            this.panelCadastros.Controls.Add(this.button3);
            this.panelCadastros.Controls.Add(this.button2);
            this.panelCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastros.Location = new System.Drawing.Point(0, 248);
            this.panelCadastros.Name = "panelCadastros";
            this.panelCadastros.Size = new System.Drawing.Size(197, 108);
            this.panelCadastros.TabIndex = 4;
            this.panelCadastros.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(197, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Usuários";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 31);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(197, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clientes";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 62);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(197, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelEngenharia
            // 
            this.panelEngenharia.Controls.Add(this.button5);
            this.panelEngenharia.Controls.Add(this.button6);
            this.panelEngenharia.Controls.Add(this.button7);
            this.panelEngenharia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEngenharia.Location = new System.Drawing.Point(0, 396);
            this.panelEngenharia.Name = "panelEngenharia";
            this.panelEngenharia.Size = new System.Drawing.Size(197, 108);
            this.panelEngenharia.TabIndex = 6;
            this.panelEngenharia.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 62);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(197, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "Controle de horas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 31);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(197, 31);
            this.button6.TabIndex = 1;
            this.button6.Text = "Projetos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(197, 31);
            this.button7.TabIndex = 0;
            this.button7.Text = "Ordem de serviço";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panelAlmoxarifado
            // 
            this.panelAlmoxarifado.Controls.Add(this.button9);
            this.panelAlmoxarifado.Controls.Add(this.button10);
            this.panelAlmoxarifado.Controls.Add(this.button11);
            this.panelAlmoxarifado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlmoxarifado.Location = new System.Drawing.Point(0, 544);
            this.panelAlmoxarifado.Name = "panelAlmoxarifado";
            this.panelAlmoxarifado.Size = new System.Drawing.Size(197, 108);
            this.panelAlmoxarifado.TabIndex = 8;
            this.panelAlmoxarifado.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 62);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(197, 31);
            this.button9.TabIndex = 2;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 31);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(197, 31);
            this.button10.TabIndex = 1;
            this.button10.Text = "...";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(197, 31);
            this.button11.TabIndex = 0;
            this.button11.Text = "Estoque";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.White;
            this.btnSair.BorderRadius = 10;
            this.btnSair.BorderSize = 1;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(748, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 24);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RION.Properties.Resources.dev_júnior__1_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlmoxarifado
            // 
            this.btnAlmoxarifado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmoxarifado.FlatAppearance.BorderSize = 0;
            this.btnAlmoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmoxarifado.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmoxarifado.ForeColor = System.Drawing.Color.White;
            this.btnAlmoxarifado.Image = global::RION.Properties.Resources.Almoxarifado_icone25x25;
            this.btnAlmoxarifado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmoxarifado.Location = new System.Drawing.Point(0, 504);
            this.btnAlmoxarifado.Name = "btnAlmoxarifado";
            this.btnAlmoxarifado.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnAlmoxarifado.Size = new System.Drawing.Size(197, 40);
            this.btnAlmoxarifado.TabIndex = 7;
            this.btnAlmoxarifado.Text = "Almoxarifado";
            this.btnAlmoxarifado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmoxarifado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmoxarifado.UseVisualStyleBackColor = true;
            this.btnAlmoxarifado.Click += new System.EventHandler(this.btnAlmoxarifado_Click);
            // 
            // btnEngenharia
            // 
            this.btnEngenharia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEngenharia.FlatAppearance.BorderSize = 0;
            this.btnEngenharia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngenharia.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngenharia.ForeColor = System.Drawing.Color.White;
            this.btnEngenharia.Image = global::RION.Properties.Resources.os_icone25x25;
            this.btnEngenharia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngenharia.Location = new System.Drawing.Point(0, 356);
            this.btnEngenharia.Name = "btnEngenharia";
            this.btnEngenharia.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEngenharia.Size = new System.Drawing.Size(197, 40);
            this.btnEngenharia.TabIndex = 5;
            this.btnEngenharia.Text = "Engenharia";
            this.btnEngenharia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngenharia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEngenharia.UseVisualStyleBackColor = true;
            this.btnEngenharia.Click += new System.EventHandler(this.btnEngenharia_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Image = global::RION.Properties.Resources.cadastros_icone20x20;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 208);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(197, 40);
            this.btnCadastros.TabIndex = 3;
            this.btnCadastros.Text = " Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.White;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::RION.Properties.Resources.icone_sem_fundo;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(47, 22);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(99, 99);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelCadastros.ResumeLayout(false);
            this.panelEngenharia.ResumeLayout(false);
            this.panelAlmoxarifado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lnUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnAlmoxarifado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnEngenharia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastros;
        public System.Windows.Forms.Panel panelCadastros;
        public System.Windows.Forms.Panel panelAlmoxarifado;
        public System.Windows.Forms.Panel panelEngenharia;
        private CustomControls.RJControls.RJButton btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}