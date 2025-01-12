namespace Desafios.modelos;

public class Pessoa(string nome, int idade)
{
  private string Nome { get; } = nome;
  private int Idade { get; } = idade;

  public override string ToString()
  {
    return $"{this.Nome} tem {this.Idade} anos de idade.";
  }
}
