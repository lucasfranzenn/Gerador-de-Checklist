using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Checklist.Properties;
using NPOI.XWPF;
using NPOI.XWPF.UserModel;

namespace Gerador_de_Checklist
{
    public static class DocumentoDocx
    {
        public static void GerarArquivo(CamposChecklist campos)
        {
            using (FileStream arquivo = new FileStream(Settings.Default.DefaultReport, FileMode.Open, FileAccess.ReadWrite))
            {
                XWPFDocument documento = new(arquivo);

                documento.FindAndReplaceText("{autor}", campos.Autor);
                documento.FindAndReplaceText("{tarefa}", campos.Tarefa);
                documento.FindAndReplaceText("{status}", campos.Status);
                documento.FindAndReplaceText("{versao}", campos.Versao);
                documento.FindAndReplaceText("{data}", campos.Data);

                for(int i=1; i<= ListaRequisito.Linhas; i++)
                {
                    if (campos.Passou[i - 1])
                    {
                        documento.FindAndReplaceText($"{{p{i}}}", "Sim");
                    }
                    else
                    {
                        documento.FindAndReplaceText($"{{p{i}}}", "Não");
                    }
                    documento.FindAndReplaceText($"{{o{i}}}", campos.Observacao[i - 1]);
                }

                FileStream saida = new(Settings.Default.OutputDir + @$"\{campos.Tarefa}.docx", FileMode.Create, FileAccess.Write);
                documento.Write(saida);
            }

        }
    }
}
