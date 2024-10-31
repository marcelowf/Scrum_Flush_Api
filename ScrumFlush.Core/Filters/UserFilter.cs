namespace ScrumFlush.Core.Filters
{
    public class UserFilter : BaseFilter
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Role { get; set; }
        public string? Position { get; set; }
    }
}
