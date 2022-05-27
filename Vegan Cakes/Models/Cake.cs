namespace Vegan_Cakes.Models
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbUrl { get; set; }

        public bool IsCakeOfWeek { get; set; }

        public bool IsInStock { get; set; }
    }
}
