namespace ScreenSound.Modelos;

class Banda
{
  private List<Album> albuns = new();
  private List<int> notas = new();
  public string Nome { get; }
  public double Media => notas.Average();
  public List<Album> Albuns => albuns;

  public Banda(string nome)
  {
    Nome = nome;
  }

  public void AdicionarAlbum(Album album)
  {
    albuns.Add(album);
  }

  public void AdicionarNota(int nota)
  {
    notas.Add(nota);
  }

  public void ExibirDiscografia()
  {
    Console.WriteLine($"Discografia da banda {Nome}");
    foreach (Album album in albuns)
    {
      Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
    }
  }
}