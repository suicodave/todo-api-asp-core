using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApiTraining.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }



    }

}
