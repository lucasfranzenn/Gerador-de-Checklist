using Gerador_de_Checklist.Properties;
using MySqlConnector;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static Gerador_de_Checklist.Funcoes;

namespace Gerador_de_Checklist
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private async void btnGerar_Click(object sender, EventArgs e)
        {
            if (VerificaAutorTarefa(txtAutor.Text, txtTarefa.Text))
            {
                Mensagem("Preencha os campos autor e tarefa!", 1);
                return;
            }

            PegaCampos(out CamposChecklist campos);
            DocumentoDocx.GerarArquivo(campos);
            new Task(() => AtualizarBanco(campos)).Start();

            Mensagem($"Checklist gerado: {campos.Tarefa}", 2);

            LimparTabela();
        }

        private void LimparTabela()
        {
            txtAutor.Text = "";
            txtTarefa.Text = "";

            foreach (var item in tlpRequisitos.Controls.OfType<CheckBox>())
            {
                var id = int.Parse(item.Name.Replace("cbox", ""));
                var txt = tlpRequisitos.Controls.OfType<RichTextBox>().FirstOrDefault(control => control.Name == $"txtOBS{id}");
                item.Checked = false;
                txt.Text = "";
            }
        }

        private void PegaCampos(out CamposChecklist camposChecklist)
        {
            camposChecklist = new CamposChecklist();

            camposChecklist.Autor = txtAutor.Text.Trim();
            camposChecklist.Tarefa = txtTarefa.Text.Trim();

            foreach (var item in tlpRequisitos.Controls.OfType<CheckBox>().Cast<Control>().Concat(tlpRequisitos.Controls.OfType<RichTextBox>().Cast<Control>()))
            {
                if (item is CheckBox checkbox)
                    camposChecklist.Passou.Add(checkbox.Checked);
                else if (item is RichTextBox richTextBox)
                    camposChecklist.Observacao.Add(string.IsNullOrEmpty(richTextBox.Text) ? Settings.Default.DefaultMessage : richTextBox.Text);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void frmPrincipal_Shown(object sender, EventArgs e)
        {
            await Task.Run(() => CarregaRequisitos());
        }

        private void CarregaRequisitos()
        {
            tlpRequisitos.SuspendLayout();

            tlpRequisitos.ColumnCount = ListaRequisito.Colunas;
            tlpRequisitos.RowCount = ListaRequisito.Linhas;

            tlpRequisitos.RowStyles.Clear();

            for (int i = 0; i < ListaRequisito.Linhas; i++)
            {
                tlpRequisitos.RowStyles.Add(new(SizeType.Absolute, 60F));

                Label lblFuncionalidade = CriaLabelFuncionalidade(i);
                Label lblDesc = CriaLabelDescricao(i);
                CheckBox cboxPassou = CriaCheckboxPassou(i);
                RichTextBox txtOBS = CriaTextboxOBS(i);

                CriaComponentesLinha(i, lblFuncionalidade, lblDesc, cboxPassou, txtOBS);
            }

            BeginInvoke(new Action(() => tlpRequisitos.ResumeLayout()));
        }

        private void CriaComponentesLinha(int i, Label lblFuncionalidade, Label lblDesc, CheckBox cboxPassou, RichTextBox txtOBS)
        {
            BeginInvoke(new Action(() =>
            {
                tlpRequisitos.Controls.Add(lblFuncionalidade, 0, i);
                tlpRequisitos.Controls.Add(lblDesc, 1, i);
                tlpRequisitos.Controls.Add(cboxPassou, 2, i);
                tlpRequisitos.Controls.Add(txtOBS, 3, i);
            }));
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmConfig().ShowDialog();
        }

        private void txtTarefa_Leave(object sender, EventArgs e)
        {
            if (VerificaAutorTarefa(" ", txtTarefa.Text)) return;

            foreach (var cb in tlpRequisitos.Controls.OfType<CheckBox>())
            {
                var idRequisito = int.Parse(cb.Name.Replace("cbox", ""));
                var txt = tlpRequisitos.Controls.OfType<RichTextBox>().FirstOrDefault(control => control.Name == $"txtOBS{idRequisito}");

                using (var select = new MySqlCommand("SELECT t.nome_testador, r.passou, r.observacao FROM requisitos r JOIN tarefas t ON t.id_tarefa = r.id_tarefa WHERE r.id_tarefa = @idTarefa and r.id_requisito = @idRequisito", Conexao.connection))
                {
                    select.Parameters.AddWithValue("@idTarefa", txtTarefa.Text);
                    select.Parameters.AddWithValue("@idRequisito", idRequisito);

                    using (var reader = select.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cb.Checked = Convert.ToBoolean(reader["passou"]);
                            txt.Text = reader["observacao"].ToString();
                            txtAutor.Text = reader["nome_testador"].ToString();
                        }
                    }
                }
            }

        }

        private void AutoComplete()
        {
            AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();

            using (MySqlCommand cmd = new MySqlCommand("select nome_Testador from tarefas", Conexao.connection))
            using (MySqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                    autocomplete.Add(reader["nome_Testador"].ToString());

            txtAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAutor.AutoCompleteCustomSource = autocomplete;
        }

        private void txtAutor_Enter(object sender, EventArgs e)
        {
            try
            {
                AutoComplete();

            }
            catch(Exception ex)
            {
                Mensagem(ex.Message, 3);
            }
        }
    }
}
