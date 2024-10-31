using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;

namespace ScrumFlush.Application.Interfaces
{
    public interface IRoomApplicationService : IBaseApplicationService<RoomGetDTO, RoomPostDTO, RoomPutDTO, RoomFilter>
    {
        
    }
}
