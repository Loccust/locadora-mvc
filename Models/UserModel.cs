using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locadora.Models
{
    [Table("Users")]
    public class UserModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
        public System.DateTime CreationDate { get; set; }
        public AddressModel Address { get; set; }
        public ContactModel ContactModel { get; set; }
   }
}
