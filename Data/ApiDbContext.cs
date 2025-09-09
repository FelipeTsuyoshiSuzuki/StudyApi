using System;
using Microsoft.EntityFrameworkCore;
using StudyApi.Models;

namespace StudyApi.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    public DbSet<Produto> Produtos { get; set; }
}
