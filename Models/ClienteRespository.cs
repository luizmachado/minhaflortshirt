using System.Collections.Generic;
using System.Linq;

namespace minhaflortshirt.Models
{
    public class ClienteRespository
    {
        public void Insert(Cliente novoCliente)
        {
            using(var context = new AppDBContext())
            {
                context.Clientes.Add(novoCliente);
                context.SaveChanges();
            }
        }

        public ICollection<Cliente> List()
        {
            using(var context = new AppDBContext())
            {
                return context.Clientes.ToList();
            }
        }
    }
}