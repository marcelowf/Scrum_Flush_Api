using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
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

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var user = await this.userApplicationService.GetById(id);
                if (user == null)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDTO userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await this.userApplicationService.Create(userDto);
                return CreatedAtAction(nameof(GetById), new { id = userDto.Id }, userDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserDTO userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var existingUser = await this.userApplicationService.GetById(id);
                if (existingUser == null)
                    return NotFound();

                await this.userApplicationService.Update(id, userDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var existingUser = await this.userApplicationService.GetById(id);
                if (existingUser == null)
                    return NotFound();

                await this.userApplicationService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("SoftDelete/{id}")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            try
            {
                var existingUser = await this.userApplicationService.GetById(id);
                if (existingUser == null)
                    return NotFound();

                await this.userApplicationService.SoftDelete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
