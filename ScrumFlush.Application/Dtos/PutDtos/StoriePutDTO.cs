namespace ScrumFlush.Application.Dtos.Put
{
    public class StoriePutDTO : BasePutDTO
    {
        public required Guid SprintId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
    }
}