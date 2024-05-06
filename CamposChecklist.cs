using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Checklist
{
    public class CamposChecklist
    {
        private string autor;
        private string tarefa;
        private readonly string versao = "1.0";
        private readonly string status = "Criação do Documento";
        private string data = DateTime.Now.ToString("dd/MM/yyyy");
        private List<bool> passou = new();
        private List<string> observacao = new();

        public string Autor { get => autor; set => autor = value; }
        public string Tarefa { get => tarefa; set => tarefa = value; }

        public string Versao => versao;

        public string Status => status;

        public string Data { get => data; set => data = value; }
        public List<bool> Passou { get => passou; set => passou = value; }
        public List<string> Observacao { get => observacao; set => observacao = value; }

        public CamposChecklist()
        {
           
        }
    }
}
