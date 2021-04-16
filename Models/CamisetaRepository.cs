using System.Collections.Generic;
using System.Linq;

namespace minhaflortshirt.Models
{
    public class CamisetaRepository
    {
        public void Insert(Camiseta novaCamiseta)
        {
            using (var context = new AppDBContext())
            {
                context.Camisetas.Add(novaCamiseta);
                context.SaveChanges();
            }
        }

        public ICollection<Camiseta> List()
        {
            using (var context = new AppDBContext())
            {
                return context.Camisetas.ToList();
            }
        }
    }
}