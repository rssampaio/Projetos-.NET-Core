using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage="Id é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage="Nome é obrigatório")]
        [StringLength(60,ErrorMessage="Nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage="Email é obrigatório")]
        [EmailAddress(ErrorMessage="Email em formato inválido")]
        [StringLength(100,ErrorMessage="Email deve ter no máximo {1} caracteres")]
        public string Email { get; set; }
    }
}