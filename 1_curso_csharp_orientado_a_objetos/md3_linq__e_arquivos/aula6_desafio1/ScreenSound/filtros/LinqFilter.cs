using System.Linq;
using ScreenSound.modelos;

internal class LinqFilter
{
  public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
  {
    // O Distinct vai evitar generos repetidos na lista
    var todosOsGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();

    foreach (var genero in todosOsGenerosMusicas)
    {
      System.Console.WriteLine($"- {genero}");
    }
  }

  public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
  {
    var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
    System.Console.WriteLine($"Exibindo artistas do gênero {genero}");
    foreach (var artista in artistasPorGeneroMusical)
    {
      System.Console.WriteLine($"- {artista}");
    }
  }

  public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
  {
    var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
    System.Console.WriteLine($"Músicas do {artista}:");
    foreach (var musica in musicasDoArtista)
    {
      System.Console.WriteLine($"- {musica.Nome}");
    }
  }
}