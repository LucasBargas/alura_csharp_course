using ScreenSound.modelos;

namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
  // private List<Album> albuns = new();
  private List<Album> albuns = [];
  // private List<int> notas = new();
  private List<Avaliacao> notas = [];
  public string Nome { get; }
  public double Media
  {
    get
    {
      return this.notas.Count == 0 ? 0 : this.notas.Average(a => a.Nota);
    }
  }
  public string? Resumo { get; set; }
  public List<Album> Albuns => albuns;

  public Banda(string nome)
  {
    this.Nome = nome;
  }

  public void AdicionarAlbum(Album album)
  {
    albuns.Add(album);
  }

  public void AdicionarNota(Avaliacao nota)
  {
    notas.Add(nota);
  }

  public void ExibirDiscografia()
  {
    Console.WriteLine($"Discografia da banda {this.Nome}");
    foreach (Album album in albuns)
    {
      Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
    }
  }
}