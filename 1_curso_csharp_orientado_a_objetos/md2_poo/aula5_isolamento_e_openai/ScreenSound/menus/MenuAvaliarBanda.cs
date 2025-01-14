using ScreenSound.modelos;
using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuAvaliarBanda : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    this.ExibirTituloDaOpcao("Avaliar banda");

    System.Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      System.Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece: ");
      Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
      bandasRegistradas[nomeDaBanda].AdicionarNota(nota);

      System.Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
      Thread.Sleep(2000);
      Console.Clear();
    }
    else
    {
      VerificaSeBandaExiste(bandasRegistradas, nomeDaBanda);
    }
  }
}