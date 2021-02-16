using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStore.Model
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
        public System.DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "O Documento é obrigatório", AllowEmptyStrings = false)]
        public string Document { get; set; }
        [Required(ErrorMessage = "O telefone de contato é obrigatório", AllowEmptyStrings = false)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "O email de contato é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O CEP do endereço é obrigatório", AllowEmptyStrings = false)]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O logradouro do endereço é obrigatório", AllowEmptyStrings = false)]
        public string Street { get; set; }
        [Required(ErrorMessage = "O número do endereço é obrigatório", AllowEmptyStrings = false)]
        public int Number { get; set; }
        public string Complement { get; set; }
   }
}
