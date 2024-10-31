using System.ComponentModel.DataAnnotations;

namespace ScrumFlush.Application.Dtos.Put
{
    public class BasePutDTO
    {
        [Required(ErrorMessage = "O campo AuthorId é obrigatório.")]
        public required Guid AuthorId { get; set; }
    }
}
