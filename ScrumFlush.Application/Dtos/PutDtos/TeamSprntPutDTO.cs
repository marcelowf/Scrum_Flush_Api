namespace ScrumFlush.Application.Dtos.Put
{
    public class TeamSprintPutDTO : BasePutDTO
    {
        public required Guid TeamId { get; set; }
        public required Guid SprintId { get; set; }
    }
}