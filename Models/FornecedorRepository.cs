using System.Collections.Generic;
using System.Linq;

namespace minhaflortshirt.Models
{
    public class FornecedorRepository
    {
        public void Insert(Fornecedor novoFornecedor)
        {
            using(var context = new AppDBContext())
            {
                context.Fornecedores.Add(novoFornecedor);
                context.SaveChanges();
            }
        }

        public ICollection<Fornecedor> ListFornecedor()
        {
            using(var context = new AppDBContext())
            {
                return context.Fornecedores.ToList();
            }
        }
    }
}