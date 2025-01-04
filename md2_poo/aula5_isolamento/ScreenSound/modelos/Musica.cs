namespace ScreenSound.Modelos;

internal class Musica
{
  public string Nome { get; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }
  public string DescricaoResumida => $"A música {this.Nome} pertence à banda {this.Artista}";

  public Musica(Banda artista, string nome)
  {
    this.Artista = artista;
    this.Nome = nome;
  }

  public void ExibirFichaTecnica()
  {
    Console.WriteLine($"Nome: {this.Nome}");
    Console.WriteLine($"Artista: {this.Artista.Nome}");
    Console.WriteLine($"Duração: {this.Duracao}");
    if (this.Disponivel)
    {
      Console.WriteLine("Disponível no plano.");
    }
    else
    {
      Console.WriteLine("Adquira o plano Plus+");
    }
  }
}