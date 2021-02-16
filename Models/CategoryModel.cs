using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStore.Model
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "A descrição da categoria é obrigatória", AllowEmptyStrings = false)]
        public string Description { get; set; }
   }
}
