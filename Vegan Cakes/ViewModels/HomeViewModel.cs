using System.Collections.Generic;
using Vegan_Cakes.Models;

namespace Vegan_Cakes.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public IEnumerable<Cake> Cakes { get; set; }

    }
}
