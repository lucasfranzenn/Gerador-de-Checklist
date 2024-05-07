using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerador_de_Checklist.Properties;

namespace Gerador_de_Checklist
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarConfiguracoes();

            Conexao.AtualizarConexao();

            Dispose();
        }

        private void SalvarConfiguracoes()
        {
            Settings.Default.Host = txtHost.Text.Trim().ToLower();
            Settings.Default.Port = txtPorta.Text.Trim().ToLower();
            Settings.Default.User = txtUsuario.Text.Trim();
            Settings.Default.Password = txtSenha.Text.Trim();
            Settings.Default.Database = txtBancoDeDados.Text.Trim().ToLower();
            Settings.Default.DefaultMessage = txtMensagemPadrao.Text.Trim();

            Settings.Default.OutputDir = txtSaidaArquivos.Text;
            Settings.Default.DefaultReport = txtCaminhoArquivoBase.Text;

            Settings.Default.Save();
        }

        private void frmConfig_Shown(object sender, EventArgs e)
        {
            CarregaConfigConexao();

            txtHost.Focus();
        }

        private void CarregaConfigConexao()
        {
            txtHost.Text = Settings.Default.Host;
            txtPorta.Text = Settings.Default.Port;
            txtUsuario.Text = Settings.Default.User;
            txtSenha.Text = Settings.Default.Password;
            txtBancoDeDados.Text = Settings.Default.Database;
            txtMensagemPadrao.Text = Settings.Default.DefaultMessage;

            txtSaidaArquivos.Text = Settings.Default.OutputDir;
            txtCaminhoArquivoBase.Text = Settings.Default.DefaultReport;
        }

        private void btnProcurarDiretorio_Click(object sender, EventArgs e)
        {
            fbdSaidaArquivos.InitialDirectory = txtSaidaArquivos.Text;

            if (fbdSaidaArquivos.ShowDialog() == DialogResult.OK)
            {
                txtSaidaArquivos.Text = fbdSaidaArquivos.SelectedPath;
            }
        }

        private void btnProcuraArquivo_Click(object sender, EventArgs e)
        {
            ofdArquivoBase.InitialDirectory = txtCaminhoArquivoBase.Text;

            if (ofdArquivoBase.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivoBase.Text = ofdArquivoBase.FileName;
            }
        }

        private void lblMensagemPadrao_MouseHover(object sender, EventArgs e)
        {
            ttDica.Show("Mensagem padrão que será utilizada quando a descrição do requisito estiver em branco.", lblMensagemPadrao);
        }
    }
}
