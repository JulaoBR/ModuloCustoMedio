using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class ModelFornecedor : ModelProduto
    {
        public int for_cod { get; set; }
        public string for_descricao { get; set; }
        public string for_email { get; set; }
        public int for_prazo_entrega { get; set; }
    }
}
