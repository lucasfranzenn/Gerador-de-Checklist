using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Checklist
{
    public static class ListaRequisito
    {
        //Preferi usar array por causa que são valores pré-definidos e saberei onde localizá-los, assim, para a busca o array sendo o(1).
        public readonly static Requisito[] ListaRequisitos = new Requisito[]
        {
            new Requisito(1, "Funcionalidade", "Verificar se todas as novas funcionalidades implementadas operam conforme esperado."),
            new Requisito(2, "Funcionalidade", "Verificar as ações dos botões e seu comportamento caso não seja selecionado nenhum registro para testar sua funcionalidade."),
            new Requisito(3, "Funcionalidade", "Verificar se o formulário está abrindo centralizado."),
            new Requisito(4, "Funcionalidade", "Verificar se está sendo possível mover o formulário."),
            new Requisito(5, "Funcionalidade", "Verificar se os botões da tela possuem atalhos. Se é possível fechar o formulário com esc, não tem a necessidade de adicionar atalhos para os botões sair e fechar. Botões como o \" Personalizar\" também não precisa de atalho."),
            new Requisito(6, "Funcionalidade", "Verificar se os botões estão respeitando o estilo de personalização definido pelo usuário."),
            new Requisito(7, "Funcionalidade", "Verificar se a sequência do foco está correta."),
            new Requisito(8, "Funcionalidade", "Verificar se é possível passar o foco com a tecla ENTER."),
            new Requisito(9, "Funcionalidade", "Verificar se os campos de texto estão respeitando a quantidade máxima de caracteres para não gerar estouro."),
            new Requisito(10, "Funcionalidade", "Verificar se operações de consulta, edição e inserção estão tratando o uso de aspas simples."),
            new Requisito(11, "Funcionalidade", "Verificar se o campo de pesquisa está funcionando corretamente quando colocamos aspas simples nos campos."),
            new Requisito(12, "Funcionalidade", "Verificar se está sendo possível fazer a pesquisa através da tecla F1."),
            new Requisito(13, "Funcionalidade", "Verificar se está funcionando os atalhos para os campos de datas, tais como H, + e -"),
            new Requisito(14, "Funcionalidade", "Verificar se os campos numéricos estão realizando operações matemáticas. (TEXTBOX)"),
            new Requisito(15, "Funcionalidade", "Verificar se os componentes dos formulários ( labels, textbox, frame e etc) estão respeitando a fonte padrão."),
            new Requisito(16, "Funcionalidade", "Verificar se está cortando alguma informação inferior a 9.999.999,99"),
            new Requisito(17, "Funcionalidade", "Verificar alinhamento de campos numéricos (ex: Quantidade, valor unitário, valor total) estão alinhados a direita"),
            new Requisito(18, "Funcionalidade", "Verificar alinhamento de campos de código se estão alinhados a direita."),
            new Requisito(19, "Funcionalidade", "Verificar se o formulário apresenta erros ortográficos."),
            new Requisito(20, "Funcionalidade", "Verificar a seleção com duplo clique quando é feito a seleção de registros a partir de um grid."),
            new Requisito(21, "Funcionalidade", "Verificar se os grids possuem barras de rolagem vertical e horizontal"),
            new Requisito(22, "Funcionalidade", "Verificar se os grids respeitam as personalizações definidas pelo usuário"),
            new Requisito(23, "Integração", "Testar a integração da customização com as funcionalidades existentes do ERP."),
            new Requisito(24, "Usabilidade", "Avaliar se a customização é fácil de usar e entender pelos usuários finais."),
            new Requisito(25, "Dados", "Verificar se as operações de leitura e escrita no banco de dados são executadas corretamente sem erros."),
            new Requisito(26, "Dados", "Garantir que a customização não comprometa a integridade dos dados existentes no banco de dados."),
            new Requisito(27, "Documentação", "Confirmar se a customização está devidamente documentada."),
            new Requisito(28, "Performance", "Avaliar o desempenho da customização, especialmente em operações que demandam mais recursos."),
            new Requisito(29, "Compatibilidade de Versões Anteriores", "Assegurar que as customizações não afetem negativamente a funcionalidade existente que os usuários dependem."),
            new Requisito(30, "Testes de Interface do Usuário (UI)", "Garantir que a interface do usuário das customizações seja consistente, intuitiva e esteja livre de erros visuais."),
            new Requisito(31, "Testes de Regressão", "Executar uma suite de testes de regressão completa para todas as funcionalidades existentes que possam ser impactadas pelas novas customizações."),
            new Requisito(32, "Fluxos de Trabalho Críticos", "Verificar se os fluxos de trabalho críticos do negócio continuam a operar como esperado após as customizações. Isso inclui testes de ponta a ponta para processos de negócios chave."),
            new Requisito(33, "Integridade dos Relatórios", "Testar se a geração de relatórios e a exibição de dados não são afetadas negativamente pelas novas customizações."),
        };

        public static byte Colunas { get => (byte) typeof(Requisito).GetProperties().Length; }
        public static byte Linhas { get => (byte) ListaRequisitos.Length; }
    }
}
