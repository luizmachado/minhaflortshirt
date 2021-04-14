namespace minhaflortshirt.Models
{
    public class Camiseta
    {
        public int id_camiseta {get; set;}
        public string nome_camiseta {get; set;}
        public string tamanho_camiseta {get; set;}
        public string cor_camiseta {get; set;}
        public string estampa_camiseta {get; set;}
        public string quantidade_camiseta {get; set;}

        public int FornecedorId {get; set;}
        public Fornecedor fornecedor {get; set;}
    }
}