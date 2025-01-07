using ScreenSound.modelos;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
  private List<Avaliacao> notas = [];
  private List<Musica> musicas = new();
  public string Nome { get; }
  public int DuracaoTotal => musicas.Sum(m => m.Duracao);
  public List<Musica> Musicas => this.musicas;

  public double Media
  {
    get
    {
      return this.notas.Count == 0 ? 0 : this.notas.Average(a => a.Nota);
    }
  }

  public Album(string nome)
  {
    this.Nome = nome;
  }

  public void AdicionarMusica(Musica musica)
  {
    musicas.Add(musica);
  }

  public void ExibirMusicasDoAlbum()
  {
    Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
    foreach (var musica in musicas)
    {
      Console.WriteLine($"Música: {musica.Nome}");
    }
    Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
  }

  public void AdicionarNota(Avaliacao nota)
  {
    notas.Add(nota);
  }
}