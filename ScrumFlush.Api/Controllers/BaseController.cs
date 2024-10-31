using Microsoft.AspNetCore.Mvc;

namespace ScrumFlush.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TReadDto, TCreateDto, TUpdateDto, TService, TFilters> : ControllerBase
        where TReadDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TService : class
        where TFilters : class
    {
        protected readonly TService service;

        protected BaseController(TService service)
        {
            this.service = service;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll([FromQuery] TFilters filters)
        {
            try
            {
                var result = await (service as dynamic).GetAll(filters);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var result = await (service as dynamic).GetById(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] TCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var createdEntity = await (service as dynamic).Create(dto);
                return CreatedAtAction(nameof(GetById), new { id = (createdEntity as dynamic).Id }, createdEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(Guid id, [FromBody] TUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var existingEntity = await (service as dynamic).GetById(id);
                if (existingEntity == null)
                    return NotFound();

                await (service as dynamic).Update(id, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                if (await (service as dynamic).GetById(id) == null)
                    return NotFound();

                await (service as dynamic).Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("SoftDelete/{id}")]
        public virtual async Task<IActionResult> SoftDelete(Guid id)
        {
            try
            {
                if (await (service as dynamic).GetById(id) == null)
                    return NotFound();

                await (service as dynamic).SoftDelete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
