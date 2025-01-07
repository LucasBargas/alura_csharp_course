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
      System.Console.WriteLine(banda.Resumo);
      System.Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");

      if (banda.Albuns.Count > 0) {
        System.Console.WriteLine("\nDiscografia:");
        foreach (Album album in banda.Albuns)
        {
          System.Console.WriteLine($"{album.Nome} -> média: {album.Media}");
        }
      }

      RetornaParaOMenu();
    }
    else
    {
      Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
      Thread.Sleep(2000);
      RetornaParaOMenu();
    }
  }
}