using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class ImprimirPedido
    {
        int paginaAtual = 1;

        ModelRelatorio rinout = new ModelRelatorio();

        public ImprimirPedido(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            rinout.sender = sender;
            rinout.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(ModelPedido modeloPedido ,List<ModelRegistro> Lista)
        {
            //Variaveis de Linhas.
            float LinhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;
            int TotalRegistro = Lista.Count();

            decimal valorTotal = 0;

            //Variaveis de Margens.
            float MargemEsq = rinout.e.MarginBounds.Left - 50 ;
            float MargemSuper = rinout.e.MarginBounds.Top + 100;
            float MargemDir = rinout.e.MarginBounds.Right + 70 ;
            float MargemInfer = rinout.e.MarginBounds.Bottom;

            Pen CanetaDaImpressora = new Pen(Color.Black, 1);
            Pen CanetaDaImpressora2 = new Pen(Color.Black, 1);

            //Variaveis de Fontes.
            Font FonteNegrito = default(Font);
            Font FonteTitulo = default(Font);
            Font FonteSubTitulo = default(Font);
            Font FonteRodape = default(Font);
            Font FonteNormal = default(Font);
            Font FonteMenor = default(Font);

            //Define efeitos das fontes.
            FonteNegrito = new Font("Arial", 9, FontStyle.Bold);
            FonteTitulo = new Font("Arial", 12, FontStyle.Bold);
            FonteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
            FonteRodape = new Font("Arial", 9, FontStyle.Bold);
            FonteNormal = new Font("Arial", 9);
            FonteMenor = new Font("Arial", 8);

            //Define o valor para linha atual e da impressao
            LinhaAtual = 0;

            //Hora do sistema
            rinout.e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 130, 40, new StringFormat());

            rinout.e.Graphics.DrawString("Enviado para: " + modeloPedido.for_email, FonteRodape, Brushes.Black, MargemEsq, 40, new StringFormat());

            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);

            //CABEÇALHO DO DOCUMENTO=================================================================
            //nome da empresa
            rinout.e.Graphics.DrawString("Nº " + Convert.ToString(modeloPedido.ped_cod), FonteTitulo, Brushes.Red, MargemEsq + 40, 80, new StringFormat());

            rinout.e.Graphics.DrawString("FORMALIZAÇÃO DO PEDIDO", FonteTitulo, Brushes.Black, MargemEsq + 40, 100, new StringFormat());

            rinout.e.Graphics.DrawString("Vandréia Mara Lot", FonteMenor, Brushes.Black, MargemEsq + 480, 70, new StringFormat());
            rinout.e.Graphics.DrawString("CNPJ: 06.049.863/0001-30 - IE: 611.004.132-114", FonteMenor, Brushes.Black, MargemEsq + 480, 80, new StringFormat());
            rinout.e.Graphics.DrawString("Av. Ricardo Aparecido Bellomi, 665 - S.C.Palmeiras/SP", FonteMenor, Brushes.Black, MargemEsq + 480, 90, new StringFormat());
            rinout.e.Graphics.DrawString("Fone: 19 3672 1502", FonteMenor, Brushes.Black, MargemEsq + 480, 100, new StringFormat());

            Image image = Image.FromFile("FOTO.jpg");
            Point pp = new Point(50, 68);
            //imagem/logo se caso quiser colocar um logo
            rinout.e.Graphics.DrawImage(image, pp);

            //CABEÇALHO DO DOCUMENTO=================================================================
            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            //CABEÇALHO DO PEDIDO====================================================================
            rinout.e.Graphics.DrawString("PEDIDO X ENTREGA:", FonteNegrito, Brushes.Black, MargemEsq, 140, new StringFormat());
            rinout.e.Graphics.DrawString(Convert.ToString(modeloPedido.for_prazo_entrega) + " DIAS", FonteNormal, Brushes.Black, MargemEsq + 130, 140, new StringFormat());

            rinout.e.Graphics.DrawString("NOTA FISCAL:", FonteNegrito, Brushes.Black, MargemEsq + 500, 140, new StringFormat());

            rinout.e.Graphics.DrawString("DATA DO PEDIDO: ", FonteNegrito, Brushes.Black, MargemEsq, 160, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_data_pedido.ToString("dd/MM/yyyy"), FonteNormal, Brushes.Black, MargemEsq + 115, 160, new StringFormat());

            rinout.e.Graphics.DrawString("ENTREGA PREVISTA: ", FonteNegrito, Brushes.Black, MargemEsq + 250, 160, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_data_prevista.ToString("dd/MM/yyyy"), FonteNormal, Brushes.Black, MargemEsq + 385, 160, new StringFormat());

            rinout.e.Graphics.DrawString("ENTREGA EFETIVA: ", FonteNegrito, Brushes.Black, MargemEsq + 500, 160, new StringFormat());

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 180, MargemDir, 180);

            rinout.e.Graphics.DrawString("FORNECEDOR ", FonteNegrito, Brushes.Black, MargemEsq, 190, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.for_descricao, FonteNormal, Brushes.Black, MargemEsq, 205, new StringFormat());

            rinout.e.Graphics.DrawString("CONTATO", FonteNegrito, Brushes.Black, MargemEsq + 470, 190, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_contato, FonteNormal, Brushes.Black, MargemEsq + 470, 205, new StringFormat());

            rinout.e.Graphics.DrawString("CONDIÇÕES DE PAGAMENTO", FonteNegrito, Brushes.Black, MargemEsq, 225, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_forma_pagamento, FonteNormal, Brushes.Black, MargemEsq, 240, new StringFormat());

            rinout.e.Graphics.DrawString("FORMA DE PAGAMENTO", FonteNegrito, Brushes.Black, MargemEsq + 470, 225, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_condicao_pagamento, FonteNormal, Brushes.Black, MargemEsq + 470, 240, new StringFormat());

            //CABEÇALHO DO PEDIDO====================================================================

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 270, MargemDir, 270);

            //campos a serem impressos: cabeçalho
            rinout.e.Graphics.DrawString("QTD", FonteNegrito, Brushes.Black, MargemEsq, 273, new StringFormat());
            rinout.e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq + 60, 273, new StringFormat());
            rinout.e.Graphics.DrawString("PREÇO UNIT.", FonteNegrito, Brushes.Black, MargemEsq + 470, 273, new StringFormat());
            rinout.e.Graphics.DrawString("PREÇO TOTAL", FonteNegrito, Brushes.Black, MargemEsq + 650, 273, new StringFormat());

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 290, MargemDir, 290);

            //define quantas linhas por pagina
            LinhasPorPagina = Convert.ToInt32(rinout.e.MarginBounds.Height / FonteNormal.GetHeight(rinout.e.Graphics));

            StringFormat alinhaDireita = new StringFormat();
            alinhaDireita.Alignment = StringAlignment.Far;
            int i = 0;

            //Aqui sao lidos os dados (deixei pré-feito pra quando estivermos com o banco ja pronto)
            while (LinhaAtual < LinhasPorPagina && TotalRegistro > 0)
            {
                //obtem os valores do datareader
                var produto = Lista[i].descricao.ToString();
                var quantidade = Lista[i].quantidade.ToString();
                var preco_unitario = Lista[i].valorUnitario.ToString();
                var preco_total = Lista[i].valorTotal.ToString();

                valorTotal += Convert.ToDecimal(preco_total);

                //inicia a impressao
                PosicaoDaLinha = 295 + (LinhaAtual * FonteNormal.GetHeight(rinout.e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                rinout.e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq + 60, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString("R$ " + preco_unitario.ToString(), FonteNormal, Brushes.Black, MargemEsq + 470, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString("R$ " + preco_total.ToString(), FonteNormal, Brushes.Black, MargemEsq + 650, PosicaoDaLinha, new StringFormat());

                LinhaAtual += 1;
                TotalRegistro -= 1;
                i += 1;
            }

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, PosicaoDaLinha + 20, MargemDir, PosicaoDaLinha + 20);

            rinout.e.Graphics.DrawString("Valor Total: ", FonteNegrito, Brushes.Black, MargemEsq + 565, PosicaoDaLinha + 30, new StringFormat());
            rinout.e.Graphics.DrawString("R$ " + Convert.ToString(valorTotal), FonteNormal, Brushes.Black, MargemEsq + 650, PosicaoDaLinha + 30, new StringFormat());

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, PosicaoDaLinha + 55, MargemDir, PosicaoDaLinha + 55);
            rinout.e.Graphics.DrawString("OBSERVAÇÃO", FonteNegrito, Brushes.Black, MargemEsq , PosicaoDaLinha + 60, new StringFormat());
            rinout.e.Graphics.DrawString(modeloPedido.ped_observacao, FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha + 75, new StringFormat());

            //verifica se continua imprimindo
            if (TotalRegistro > 0)
                rinout.e.HasMorePages = true;
            else
                rinout.e.HasMorePages = false;
          
            //Incrementa o numero da pagina
            paginaAtual += 1;


            //-------------------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// finaliza a impressão
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="byvale"></param
        }
    }
}

