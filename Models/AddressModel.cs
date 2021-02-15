using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locadora.Models
{
    public class AddressModel
    {
        [Required(ErrorMessage = "O CEP do endereço é obrigatório", AllowEmptyStrings = false)]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O logradouro do endereço é obrigatório", AllowEmptyStrings = false)]
        public string Street { get; set; }
        [Required(ErrorMessage = "O número do endereço é obrigatório", AllowEmptyStrings = false)]
        public int Number { get; set; }
        public string Complement { get; set; }
    }
}