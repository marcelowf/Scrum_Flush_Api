namespace ScrumFlush.Application.Dtos.Put
{
    public class RoomPutDTO : BasePutDTO
    {
        public required Guid RoomId { get; set; }
        public string? Name { get; set; }
    }
}