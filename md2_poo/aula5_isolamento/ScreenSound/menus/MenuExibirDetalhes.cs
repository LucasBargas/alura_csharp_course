using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuExibirDetalhes : Menu
{
  internal void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
    this.ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      Banda banda = bandasRegistradas[nomeDaBanda];
      Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
      /**
      * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
      */
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