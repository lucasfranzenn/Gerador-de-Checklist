using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MySqlConnector;
using System.Security.Cryptography;
using Gerador_de_Checklist.Enum;

namespace Gerador_de_Checklist
{
    public static class Funcoes
    {
        public static Label CriaLabelDescricao(int i) => new Label
        {
            AutoEllipsis = true,
            TextAlign = ContentAlignment.MiddleLeft,
            Dock = DockStyle.Fill,
            Text = ListaRequisito.ListaRequisitos[i].Descricao
        };

        public static CheckBox CriaCheckboxPassou(int i) => new CheckBox
        {
            Dock = DockStyle.Fill,
            CheckAlign = ContentAlignment.MiddleCenter,
            Name = "cbox" + (i + 1)
        };

        public static Label CriaLabelFuncionalidade(int i) => new Label
        {
            AutoEllipsis = true,
            TextAlign = ContentAlignment.MiddleLeft,
            Dock = DockStyle.Fill,
            Text = ListaRequisito.ListaRequisitos[i].Funcionalidade
        };

        public static RichTextBox CriaTextboxOBS(int i) => new RichTextBox
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.FixedSingle,
            Multiline = true,
            Name = "txtOBS" + (i + 1)
        };

        public static bool VerificaAutorTarefa(string txtAutor, string txtTarefa) => txtAutor == "" || txtTarefa == "";

        public static void Mensagem(string mensagem, TipoMensagem opcao)
        {

            switch (opcao)
            {
                case TipoMensagem.Aviso:
                    MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case TipoMensagem.Sucesso:
                    MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case TipoMensagem.Erro:
                    MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    return;
            }
        }

        public static bool MensagemAbrirPasta(string mensagem, TipoMensagem opcao)
        {
            switch (opcao)
            {
                case TipoMensagem.Aviso:
                    if(MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        return true;
                    break;
                case TipoMensagem.Sucesso:
                    if(MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        return true;
                    break;
                case TipoMensagem.Erro:
                    if(MessageBox.Show(mensagem, $"..:: {opcao} ::..", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        return true;
                    break;
                default:
                    break;
            }
            return false;
        }

        public static void AtualizarBanco(CamposChecklist campos)
        {
            if (!TarefaExiste(campos.Tarefa))
            {
                CriaTarefa(ref campos);
            }

            for (int i = 1; i <= ListaRequisito.Linhas; i++)
            {
                using (MySqlCommand comandoUpdate = new MySqlCommand("UPDATE requisitos SET Observacao = @Observacao, passou = @Passou WHERE id_requisito = @id_requisito AND id_Tarefa = @id_Tarefa", Conexao.connection))
                {
                    comandoUpdate.Parameters.AddWithValue("@Observacao", campos.Observacao[i - 1]);
                    comandoUpdate.Parameters.AddWithValue("@Passou", campos.Passou[i - 1]);
                    comandoUpdate.Parameters.AddWithValue("@id_requisito", i);
                    comandoUpdate.Parameters.AddWithValue("@id_Tarefa", campos.Tarefa);

                    comandoUpdate.ExecuteNonQuery();
                }
            }
        }

        private static void CriaTarefa(ref CamposChecklist campos)
        {
            using (MySqlCommand insere = new MySqlCommand("INSERT INTO tarefas VALUES (@idTarefa, @Autor, @Data)", Conexao.connection))
            {
                insere.Parameters.AddWithValue("@idTarefa", campos.Tarefa);
                insere.Parameters.AddWithValue("@Autor", campos.Autor);
                insere.Parameters.AddWithValue("@Data", DateTime.Parse(campos.Data));

                insere.ExecuteNonQuery();
                for(int i=1; i<= ListaRequisito.Linhas; i++)
                {
                    var insereRequisito = new MySqlCommand("INSERT INTO requisitos VALUES (@id, @idTarefa, DEFAULT, DEFAULT)", Conexao.connection);
                    insereRequisito.Parameters.AddWithValue("@id", i);
                    insereRequisito.Parameters.AddWithValue("@idTarefa", campos.Tarefa);

                    insereRequisito.ExecuteNonQuery();
                }
            }
        }

        private static bool TarefaExiste(string tarefa)
        {
            using(MySqlCommand select = new MySqlCommand("SELECT id_tarefa FROM tarefas WHERE id_tarefa = @Tarefa", Conexao.connection))
            {
                select.Parameters.AddWithValue("@Tarefa", tarefa);
                select.ExecuteNonQuery();

                using MySqlDataReader reader = select.ExecuteReader();
                    return reader.HasRows;
            }
        }
    }
}
