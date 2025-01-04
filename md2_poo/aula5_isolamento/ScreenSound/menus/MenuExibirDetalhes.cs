using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuExibirDetalhes : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    // Chama metodo da minha classe pai, na filha, e depois executa o resto
    base.Executar(bandasRegistradas);

    this.ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      Banda banda = bandasRegistradas[nomeDaBanda];
      Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");

      System.Console.WriteLine("\nDiscografia:");
      foreach (Album album in banda.Albuns)
      { 
        System.Console.WriteLine($"{album.Nome} -> média: {album.Media}");
      }

      Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
      Console.ReadKey();
      Console.Clear();
    }
    else
    {
      Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
      Thread.Sleep(2000);
      Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
      Console.ReadKey();
      Console.Clear();
    }
  }
}