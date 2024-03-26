
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class TasksController : BaseApiController
    {
        private readonly DataContext _context;
        public TasksController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] // api/tasks
        public async Task<ActionResult<List<Domain.Task>>> GetTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        [HttpGet("{id}")] // api/tasks/{id}
        public async Task<ActionResult<Domain.Task>> GetTask(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }
    }
}