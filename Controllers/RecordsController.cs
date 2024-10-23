using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class RecordsController : ControllerBase
{

    private readonly AppDbContext _context;

    public RecordsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> SearchRecords(string query)
    {
        var results = await _context.Records
            .Where(r => r.DataField.Contains(query))
            .ToListAsync();
        return Ok(results);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRecord([FromBody] Record record)
    {
        record.SubmittedOn = DateTime.UtcNow;
        record.ModifiedOn = DateTime.UtcNow;

        _context.Records.Add(record);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Record), new { id = record.Id }, record);
    }    
}
