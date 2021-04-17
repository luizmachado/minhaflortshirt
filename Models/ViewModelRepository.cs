using System.Collections.Generic;
using minhaflortshirt.Models;

namespace minhaflortshirt.Models
{
    public class FornecedorViewModel
    {
        public ICollection<Fornecedor> Fornecedores { get; set; }
    }
    public class CamisetaViewModel
    {
        public ICollection<Camiseta> Camisetas { get; set; }
    }
    public class ClienteViewModel
    {
        public ICollection<Cliente> Clientes { get; set; }
    }
    public class ColaboradorViewModel
    {
        public ICollection<Colaborador> Colaboradores { get; set; }
    }
}