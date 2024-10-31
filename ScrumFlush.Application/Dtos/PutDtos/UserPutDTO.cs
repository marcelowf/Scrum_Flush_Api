namespace ScrumFlush.Application.Dtos.Put
{
    public class UserPutDTO : BasePutDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required int Role { get; set; }
        public required string Position { get; set; }
    }
}
