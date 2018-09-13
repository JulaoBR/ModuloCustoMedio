using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class ModelProduto
    {
        public int codProduto { get; set; }
        public string descricao { get; set; }
        public string fornecedor { get; set; }
        public string categoria { get; set; }
        public string unidade_medida { get; set; }
        public Decimal estoque_minimo { get; set; }
        public DateTime dataOperacao { get; set; }
    }
}
