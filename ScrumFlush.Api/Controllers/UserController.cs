using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
//    [Authorize]    
    public class UserController : ControllerBase
    {
        private readonly IUserApplicationService userApplicationService;

        public UserController(IUserApplicationService userApplicationService)
        {
            this.userApplicationService = userApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await this.userApplicationService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}