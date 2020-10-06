using System;
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
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z", 
            ErrorMessage ="O E-mail não está no formato correto")]
        public string Email { get; set; }

        [Display(Name = "Telefone Fixo")]
        [DataType(DataType.PhoneNumber)]
        public int Fone1 { get; set; }

        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public int Fone2 { get; set; }
    }
}
