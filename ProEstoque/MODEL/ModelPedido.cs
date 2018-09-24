using System;

namespace ProEstoque.MODEL
{
    public class ModelPedido : ModelFornecedor
    {
        public int ped_cod { get; set; }
        public int reg_cod { get; set; }
        public DateTime ped_data_pedido { get; set; }
        public DateTime ped_data_prevista { get; set; }
        public DateTime ped_data_entrega { get; set; }
        public string ped_contato { get; set; }
        public string ped_forma_pagamento { get; set; }
        public string ped_observacao { get; set; }
        public string ped_status { get; set; }
        public int status { get; set; }
        public decimal ped_quantidade { get; set; }
        public decimal ped_valor_unitario { get; set; }
        public decimal ped_valor_frete { get; set; }
        public string pro_descricao { get; set; }

        //IMPRESSAO
        public string ped_condicao_pagamento { get; set; }
    }
}
