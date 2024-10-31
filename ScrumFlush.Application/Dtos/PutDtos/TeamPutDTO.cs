namespace ScrumFlush.Application.Dtos.Put
{
    public class TeamPutDTO : BasePutDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}