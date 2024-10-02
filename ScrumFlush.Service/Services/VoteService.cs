using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class VoteService : BaseService<Vote>, IVoteService
    {
        private readonly IVoteRepository voteRepository;

        public VoteService(IVoteRepository voteRepository) : base(voteRepository)
        {
            this.voteRepository = voteRepository;
        }
    }
}