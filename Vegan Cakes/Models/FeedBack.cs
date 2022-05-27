using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Vegan_Cakes.Models
{
    public class FeedBack
    {
        [BindNever]
        public int Id { get; set; }

        [Required , DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }

        public bool ContactMe { get; set; }
    }
}
