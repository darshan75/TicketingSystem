
using Microsoft.AspNetCore.Mvc;
using TicketingSystemMongo.Interfaces;
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _service;

    public TicketController(ITicketService service)
    {
        _service = service;
    }

    [HttpGet]
public async Task<IActionResult> Get(string? status, string? priority, int page = 1, int pageSize = 10)
{
    var data = (await _service.GetAllAsync())
        .Where(x => !x.IsDeleted);

    if (!string.IsNullOrEmpty(status))
        data = data.Where(x => x.Status == status);

    if (!string.IsNullOrEmpty(priority))
        data = data.Where(x => x.Priority == priority);

    var result = data
        .Skip((page - 1) * pageSize)
        .Take(pageSize);

    return Ok(result);
}

    [HttpPost]
    public async Task<IActionResult> Create(Ticket ticket)
    {
        return Ok(await _service.CreateAsync(ticket));
    }
    [HttpGet("{id}")]
public async Task<IActionResult> GetById(string id)
{
    var data = await _service.GetByIdAsync(id);
    if (data == null) return NotFound();
    return Ok(data);
}

[HttpPut("{id}")]
public async Task<IActionResult> Update(string id, UpdateTicketDto dto)
{
    var result = await _service.UpdateAsync(id, dto);
    if (!result) return NotFound();
    return Ok("Updated");
}

[HttpDelete("{id}")]
public async Task<IActionResult> Delete(string id)
{
    var result = await _service.DeleteAsync(id);
    if (!result) return NotFound();
    return Ok("Deleted");
}
}
