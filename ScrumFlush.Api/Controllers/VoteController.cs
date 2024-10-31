using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class VoteController : BaseController<VoteGetDTO, VotePostDTO, VotePutDTO, IVoteApplicationService, VoteFilter>
    {
        public VoteController(IVoteApplicationService voteApplicationService)
            : base(voteApplicationService)
        {
        }
    }
}
