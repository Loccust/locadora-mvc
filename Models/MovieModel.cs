using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStore.Model
{
    [Table("Movies")]
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage = "O título do filme é obrigatório.", AllowEmptyStrings = false)]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "A imagem do filme é obrigatória.", AllowEmptyStrings = false)]
        public string Image { get; set; }
        
        [Required(ErrorMessage = "A categoria do filme é obrigatória.", AllowEmptyStrings = false)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "A categoria do filme é obrigatória.", AllowEmptyStrings = false)]
        public DateTime RegisteredDate { get; set; }
   }
}
