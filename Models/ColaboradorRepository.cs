using System.Collections.Generic;
using System.Linq;

namespace minhaflortshirt.Models
{
    public class ColaboradorRepository
    {
        public void Insert(Colaborador novoColaborador)
        {
            using (var context = new AppDBContext())
            {
                context.Colaboradores.Add(novoColaborador);
                context.SaveChanges();
            }
        }

        public ICollection<Colaborador> List()
        {
            using (var context = new AppDBContext())
            {
                return context.Colaboradores.ToList();
            }
        }
    }
}