using System;

namespace FuscaFilmes.Entities;

public class Diretor
{
public int Id { get; set; }
public required string Name { get; set; }
public ICollection<Filme> Filmes { get; set; } = new List<Filme>();
}
