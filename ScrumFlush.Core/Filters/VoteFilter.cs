namespace ScrumFlush.Core.Filters
{
    public class VoteFilter : BaseFilter
    {
        public Guid? RoundId { get; set; }
        public Guid? Player { get; set; }
        public Guid? Card { get; set; }
    }
}