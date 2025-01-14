using System.Text.Json;

namespace ScreenSound.modelos;

internal class MusicasPreferidas(string nome)
{
  private string? Nome { get; } = nome;
  private List<Musica> ListaDeMusicasFavoritas {get; } = [];

  public void AdicionarMusicasFavoritas(Musica musica)
  {
    ListaDeMusicasFavoritas.Add(musica);
  }

  public void ExibirMusicasFavoritas()
  {
    System.Console.WriteLine($"Essas são as músicas favoritas do {this.Nome}:");
    foreach (var musica in this.ListaDeMusicasFavoritas)
    {
      System.Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
    }
    System.Console.WriteLine();
  }

  public void GerarArquivoJson()
  {
    string json = JsonSerializer.Serialize(
      new
      {
        nome = this.Nome,
        musicas  = this.ListaDeMusicasFavoritas
      }
    );
    string nomeDoArquivo = $"musicas-favoritas-{this.Nome}.json";

    File.WriteAllText(nomeDoArquivo, json);
    System.Console.WriteLine($"O arquivo foi Json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
  }
}
