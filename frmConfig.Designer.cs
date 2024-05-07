namespace Gerador_de_Checklist
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnSair = new Button();
            tabConfig = new TabControl();
            pageConexao = new TabPage();
            txtBancoDeDados = new TextBox();
            lblBancoDeDados = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUser = new Label();
            txtPorta = new TextBox();
            lblPorta = new Label();
            txtHost = new TextBox();
            lblHost = new Label();
            pageChecklist = new TabPage();
            btnProcuraArquivo = new Button();
            txtCaminhoArquivoBase = new TextBox();
            lblArquivoBase = new Label();
            txtMensagemPadrao = new TextBox();
            lblMensagemPadrao = new Label();
            btnProcurarDiretorio = new Button();
            txtSaidaArquivos = new TextBox();
            label1 = new Label();
            btnGravar = new Button();
            fbdSaidaArquivos = new FolderBrowserDialog();
            ofdArquivoBase = new OpenFileDialog();
            tabConfig.SuspendLayout();
            pageConexao.SuspendLayout();
            pageChecklist.SuspendLayout();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(-10, -10);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(10, 10);
            btnSair.TabIndex = 0;
            btnSair.Text = "BOTÃO PARA SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // tabConfig
            // 
            tabConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabConfig.Controls.Add(pageConexao);
            tabConfig.Controls.Add(pageChecklist);
            tabConfig.Location = new Point(5, 0);
            tabConfig.Name = "tabConfig";
            tabConfig.SelectedIndex = 0;
            tabConfig.Size = new Size(549, 190);
            tabConfig.TabIndex = 1;
            // 
            // pageConexao
            // 
            pageConexao.Controls.Add(txtBancoDeDados);
            pageConexao.Controls.Add(lblBancoDeDados);
            pageConexao.Controls.Add(txtSenha);
            pageConexao.Controls.Add(lblSenha);
            pageConexao.Controls.Add(txtUsuario);
            pageConexao.Controls.Add(lblUser);
            pageConexao.Controls.Add(txtPorta);
            pageConexao.Controls.Add(lblPorta);
            pageConexao.Controls.Add(txtHost);
            pageConexao.Controls.Add(lblHost);
            pageConexao.Location = new Point(4, 24);
            pageConexao.Name = "pageConexao";
            pageConexao.Padding = new Padding(3);
            pageConexao.Size = new Size(541, 162);
            pageConexao.TabIndex = 0;
            pageConexao.Text = "Conexão";
            pageConexao.UseVisualStyleBackColor = true;
            // 
            // txtBancoDeDados
            // 
            txtBancoDeDados.BorderStyle = BorderStyle.FixedSingle;
            txtBancoDeDados.Location = new Point(133, 109);
            txtBancoDeDados.Name = "txtBancoDeDados";
            txtBancoDeDados.Size = new Size(402, 23);
            txtBancoDeDados.TabIndex = 9;
            // 
            // lblBancoDeDados
            // 
            lblBancoDeDados.AutoSize = true;
            lblBancoDeDados.Font = new Font("Segoe UI", 11F);
            lblBancoDeDados.Location = new Point(8, 109);
            lblBancoDeDados.Name = "lblBancoDeDados";
            lblBancoDeDados.Size = new Size(119, 20);
            lblBancoDeDados.TabIndex = 8;
            lblBancoDeDados.Text = "Banco de dados:";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(435, 49);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11F);
            lblSenha.Location = new Point(377, 50);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(76, 49);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(295, 23);
            txtUsuario.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 11F);
            lblUser.Location = new Point(8, 49);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuário:";
            // 
            // txtPorta
            // 
            txtPorta.BorderStyle = BorderStyle.FixedSingle;
            txtPorta.Location = new Point(435, 8);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(100, 23);
            txtPorta.TabIndex = 3;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new Font("Segoe UI", 11F);
            lblPorta.Location = new Point(377, 8);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(46, 20);
            lblPorta.TabIndex = 2;
            lblPorta.Text = "Porta:";
            // 
            // txtHost
            // 
            txtHost.BorderStyle = BorderStyle.FixedSingle;
            txtHost.Location = new Point(57, 8);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(314, 23);
            txtHost.TabIndex = 1;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 11F);
            lblHost.Location = new Point(8, 8);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(43, 20);
            lblHost.TabIndex = 0;
            lblHost.Text = "Host:";
            // 
            // pageChecklist
            // 
            pageChecklist.Controls.Add(btnProcuraArquivo);
            pageChecklist.Controls.Add(txtCaminhoArquivoBase);
            pageChecklist.Controls.Add(lblArquivoBase);
            pageChecklist.Controls.Add(txtMensagemPadrao);
            pageChecklist.Controls.Add(lblMensagemPadrao);
            pageChecklist.Controls.Add(btnProcurarDiretorio);
            pageChecklist.Controls.Add(txtSaidaArquivos);
            pageChecklist.Controls.Add(label1);
            pageChecklist.Location = new Point(4, 24);
            pageChecklist.Name = "pageChecklist";
            pageChecklist.Padding = new Padding(3);
            pageChecklist.Size = new Size(541, 162);
            pageChecklist.TabIndex = 1;
            pageChecklist.Text = "Arquivos";
            pageChecklist.UseVisualStyleBackColor = true;
            // 
            // btnProcuraArquivo
            // 
            btnProcuraArquivo.Cursor = Cursors.Hand;
            btnProcuraArquivo.FlatStyle = FlatStyle.Flat;
            btnProcuraArquivo.Image = (Image)resources.GetObject("btnProcuraArquivo.Image");
            btnProcuraArquivo.Location = new Point(510, 61);
            btnProcuraArquivo.Name = "btnProcuraArquivo";
            btnProcuraArquivo.Size = new Size(23, 23);
            btnProcuraArquivo.TabIndex = 7;
            btnProcuraArquivo.UseVisualStyleBackColor = true;
            btnProcuraArquivo.Click += btnProcuraArquivo_Click;
            // 
            // txtCaminhoArquivoBase
            // 
            txtCaminhoArquivoBase.BorderStyle = BorderStyle.FixedSingle;
            txtCaminhoArquivoBase.Location = new Point(120, 61);
            txtCaminhoArquivoBase.Name = "txtCaminhoArquivoBase";
            txtCaminhoArquivoBase.Size = new Size(384, 23);
            txtCaminhoArquivoBase.TabIndex = 6;
            // 
            // lblArquivoBase
            // 
            lblArquivoBase.AutoSize = true;
            lblArquivoBase.Font = new Font("Segoe UI", 11F);
            lblArquivoBase.Location = new Point(15, 61);
            lblArquivoBase.Name = "lblArquivoBase";
            lblArquivoBase.Size = new Size(99, 20);
            lblArquivoBase.TabIndex = 8;
            lblArquivoBase.Text = "Arquivo base:";
            // 
            // txtMensagemPadrao
            // 
            txtMensagemPadrao.BorderStyle = BorderStyle.FixedSingle;
            txtMensagemPadrao.Location = new Point(156, 122);
            txtMensagemPadrao.Name = "txtMensagemPadrao";
            txtMensagemPadrao.Size = new Size(377, 23);
            txtMensagemPadrao.TabIndex = 8;
            // 
            // lblMensagemPadrao
            // 
            lblMensagemPadrao.AutoSize = true;
            lblMensagemPadrao.Font = new Font("Segoe UI", 11F);
            lblMensagemPadrao.Location = new Point(15, 122);
            lblMensagemPadrao.Name = "lblMensagemPadrao";
            lblMensagemPadrao.Size = new Size(135, 20);
            lblMensagemPadrao.TabIndex = 6;
            lblMensagemPadrao.Text = "Mensagem Padrão:";
            // 
            // btnProcurarDiretorio
            // 
            btnProcurarDiretorio.Cursor = Cursors.Hand;
            btnProcurarDiretorio.FlatStyle = FlatStyle.Flat;
            btnProcurarDiretorio.Image = (Image)resources.GetObject("btnProcurarDiretorio.Image");
            btnProcurarDiretorio.Location = new Point(510, 15);
            btnProcurarDiretorio.Name = "btnProcurarDiretorio";
            btnProcurarDiretorio.Size = new Size(23, 23);
            btnProcurarDiretorio.TabIndex = 5;
            btnProcurarDiretorio.UseVisualStyleBackColor = true;
            btnProcurarDiretorio.Click += btnProcurarDiretorio_Click;
            // 
            // txtSaidaArquivos
            // 
            txtSaidaArquivos.BorderStyle = BorderStyle.FixedSingle;
            txtSaidaArquivos.Location = new Point(222, 15);
            txtSaidaArquivos.Name = "txtSaidaArquivos";
            txtSaidaArquivos.Size = new Size(282, 23);
            txtSaidaArquivos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 1;
            label1.Text = "Saída para arquivos gerados:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.Cursor = Cursors.Hand;
            btnGravar.FlatStyle = FlatStyle.Popup;
            btnGravar.Location = new Point(451, 196);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 44);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // fbdSaidaArquivos
            // 
            fbdSaidaArquivos.InitialDirectory = "C:";
            // 
            // ofdArquivoBase
            // 
            ofdArquivoBase.FileName = "openFileDialog1";
            ofdArquivoBase.Filter = "Arquivos DOCX|*.docx|Todos os arquivos|*.*";
            ofdArquivoBase.InitialDirectory = "C:";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new Size(557, 244);
            Controls.Add(btnGravar);
            Controls.Add(tabConfig);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(573, 258);
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Shown += frmConfig_Shown;
            tabConfig.ResumeLayout(false);
            pageConexao.ResumeLayout(false);
            pageConexao.PerformLayout();
            pageChecklist.ResumeLayout(false);
            pageChecklist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private TabControl tabConfig;
        private TabPage pageConexao;
        private TabPage pageChecklist;
        private Button btnGravar;
        private Label lblHost;
        private TextBox txtUsuario;
        private Label lblUser;
        private TextBox txtPorta;
        private Label lblPorta;
        private TextBox txtHost;
        private TextBox txtBancoDeDados;
        private Label lblBancoDeDados;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label label1;
        private FolderBrowserDialog fbdSaidaArquivos;
        private Button btnProcurarDiretorio;
        private TextBox txtSaidaArquivos;
        private TextBox txtMensagemPadrao;
        private Label lblMensagemPadrao;
        private Button btnProcuraArquivo;
        private TextBox txtCaminhoArquivoBase;
        private Label lblArquivoBase;
        private OpenFileDialog ofdArquivoBase;
    }
}