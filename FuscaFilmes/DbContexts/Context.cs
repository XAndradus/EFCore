using System;
using Microsoft.EntityFrameworkCore;
using FuscaFilmes.Entities;

namespace FuscaFilmes.DbContexts;

public class Context (DbContextOptions<Context> options): DbContext(options)
{
public DbSet<Filme> Filmes { get; set; }
public DbSet<Diretor> Diretores { get; set; }

// protected override void OnConfiguring(DbContextOptionsBuilder options)
//     => options.UseSqlite("Data Source = EFCoreConsole.db");
}
