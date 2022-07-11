using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Genero { get; set; }
        [Range(1, 300, ErrorMessage = "A duração deve ter no minimo 1 e no máximo 300 minutos")]
        public int Duracao { get; set; }
    }
}
