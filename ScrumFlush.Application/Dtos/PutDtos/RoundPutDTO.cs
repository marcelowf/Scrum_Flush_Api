namespace ScrumFlush.Application.Dtos.Put
{
    public class RoundPutDTO : BasePutDTO
    {
        public required Guid RoomId { get; set; }
        public required Guid StorieId { get; set; }
    }
}