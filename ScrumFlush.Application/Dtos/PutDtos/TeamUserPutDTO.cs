using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Put
{
    public class TeamUserPutDTO : BasePutDTO
    {
        public required Guid TeamId { get; set; }
        public required Guid UserId { get; set; }
        public required TeamUserRole TeamUserRole { get; set; }
    }
}