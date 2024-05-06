using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Checklist
{
    public class Requisito
    {
        public readonly byte Id;
        public readonly string Funcionalidade;
        public readonly string Descricao;

        public Requisito(byte id, string funcionalidade, string descricao)
        {
            this.Id = id;
            this.Funcionalidade = funcionalidade;
            this.Descricao = descricao;
        }
    }
}
