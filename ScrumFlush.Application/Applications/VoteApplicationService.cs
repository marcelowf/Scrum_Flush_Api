using AutoMapper;
using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class VoteApplicationService : BaseApplicationService<VoteGetDTO, VotePostDTO, VotePutDTO, Vote, VoteFilter>, IVoteApplicationService
    {
        private readonly IVoteService voteService;

        public VoteApplicationService(IMapper mapper, IVoteService voteService)
            : base(mapper, (IBaseService<Vote, VoteFilter>)voteService)
        {
            this.voteService = voteService;
        }
    }
}
