using System.Collections.Generic;

namespace Vegan_Cakes.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> getAllCakes();

        Cake getcakeById(int id);
    }
}
