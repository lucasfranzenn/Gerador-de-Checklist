using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Checklist.Enum;
using Gerador_de_Checklist.Properties;
using MySqlConnector;

namespace Gerador_de_Checklist
{
    public class Conexao
    {
        private static string _host = Settings.Default.Host;
        private static string _port = Settings.Default.Port;
        private static string _user = Settings.Default.User;
        private static string _password = Settings.Default.Password;
        private static string _database = Settings.Default.Database;
        public static MySqlConnection? connection;

        private static Conexao instancia = new();
        public static Conexao Instancia => instancia;

        private Conexao()
        {
            connection = new($"Server={_host};Port={_port};User Id={_user};Password ={_password};Database={_database}");

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Funcoes.Mensagem(e.Message, TipoMensagem.Erro);
            }
        }

        public static void AtualizarConexao()
        {
            _host = Settings.Default.Host;
            _port = Settings.Default.Port;
            _user = Settings.Default.User;
            _password = Settings.Default.Password;
            _database = Settings.Default.Database;

            instancia = new();
        }
    }
}
