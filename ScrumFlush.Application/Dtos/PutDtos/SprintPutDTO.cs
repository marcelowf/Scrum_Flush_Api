using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Put
{
    public class SprintPutDTO : BasePutDTO
    {
        public required string Name { get; set; }
        public required SprintStatus Status { get; set; }
        public int? TotalPoints { get; set; }
    }
}