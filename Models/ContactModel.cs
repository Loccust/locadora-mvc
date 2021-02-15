using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace locadora.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "O Documento é obrigatório", AllowEmptyStrings = false)]
        public string Document { get; set; }
        [Required(ErrorMessage = "O telefone de contato é obrigatório", AllowEmptyStrings = false)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "O email de contato é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }
    }
}