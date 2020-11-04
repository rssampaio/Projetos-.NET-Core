using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Informe o Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Sobrenome")]
        [StringLength(150)]
        public string Sobrenome { get; set; }
        
        [StringLength(150)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        
        [StringLength(150)]
        public string Complemento { get; set; }
        
        [Display(Name ="Número")]
        public int NroEndereco { get; set; }

        [StringLength(100)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(10, MinimumLength =8)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [Display(Name = "E-mail")]
        [StringLength(150)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        public string Email { get; set; }

        [Display(Name = "Telefone Fixo")]
        public int Fone1 { get; set; }

        [Display(Name = "Celular")]
        public int Fone2 { get; set; }

    }
}
