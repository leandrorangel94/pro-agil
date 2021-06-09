using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.API.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Local tem que ter entre 3 a 100 caracteres.")]
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O Tema deve ser preenchido.")]
        public string Tema { get; set; }

        [Range(1, 120000, ErrorMessage = "A quantidade deve ser entre 1 a 120 mil pessoas.")]
        public int QtdPessoas { get; set; }
        public string ImageURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}