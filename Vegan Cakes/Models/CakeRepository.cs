using System.Collections.Generic;
using System.Linq;

namespace Vegan_Cakes.Models
{
    public class CakeRepository : ICakeRepository
    {
        private readonly AppDbContext context;

        public CakeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Cake> getAllCakes()
        {
            return context.Cakes;
        }

        public Cake getcakeById(int id)
        {
            return context.Cakes.FirstOrDefault(c => c.Id == id);
        }
    }
}
