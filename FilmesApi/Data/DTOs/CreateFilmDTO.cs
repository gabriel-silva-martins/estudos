using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs;

public class CreateFilmDTO
{
    [Required(ErrorMessage = "O título do filme é um parâmetro obrigatório.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O gênero do filme é um parâmetro obrigatório.")]
    [StringLength(50, ErrorMessage = "O gênero tem um limite de 50 caracteres.")]
    public string? Gender { get; set; }

    [Required(ErrorMessage = "A duração do filme é um parâmetro obrigatório.")]
    [Range(70, 350, ErrorMessage = "A duração do filme deve de ter entre 70 a 350 minutos.")]
    public int Duration { get; set; }
}
