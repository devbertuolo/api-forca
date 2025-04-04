using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    // Adicione o DbSet para a tabela PALAVRAS
    public DbSet<Palavra> Palavras { get; set; } = null!;
}