using System;

namespace ProEstoque.MODEL
{
    public class ModelRegistro : ModelProduto
    {
        public int reg_cod { get; set; }
        public int for_cod { get; set; }
        public int cat_cod { get; set; }
        public int tipo_cod { get; set; }
        public string tipo_descricao { get; set; }
        public decimal quantidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorFrete { get; set; }
        public decimal valorTotal { get; set; }
        public decimal custoMedio { get; set; }
        public decimal saldo { get; set; }
        public decimal valorPorcentual { get; set; }
        public int reg_status { get; set; }

    }
}
