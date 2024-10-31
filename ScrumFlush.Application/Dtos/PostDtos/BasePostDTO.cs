using System.ComponentModel.DataAnnotations;

namespace ScrumFlush.Application.Dtos.Post
{
    public class BasePostDTO
    {
        [Required(ErrorMessage = "O campo AuthorId é obrigatório.")]
        public required Guid AuthorId { get; set; }
    }
}
