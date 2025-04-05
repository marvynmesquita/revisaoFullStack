using Microsoft.EntityFrameworkCore;
using MinhaApp.Dominio;

namespace MinhaApp.Repositorio;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
