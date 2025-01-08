using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuMostrarBandas : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    Dictionary<int, Menu> opcoes = new()
    {
      {1, new MenuRegistrarBanda()},
      {-1, new MenuSair()},
    };

    if (bandasRegistradas.Count > 0)
    {
      foreach (string banda in bandasRegistradas.Keys)
      {
        Console.WriteLine($"Banda: {banda}");
      }

      Thread.Sleep(2000);
      RetornaParaOMenu();
    }
    else
    {
      System.Console.WriteLine("Ainda não há bandas registradas!");
      System.Console.WriteLine("\nDeseja registrar uma banda?");

      Console.WriteLine("\nDigite 1 para registrar uma banda");
      Console.WriteLine("Digite -1 para voltar ao menu principal");

      Console.Write("\nDigite a sua opção: ");
      int opcaoEscolhida = int.Parse(Console.ReadLine()!);

      if (opcoes.ContainsKey(opcaoEscolhida))
      {
        Menu menuASerExibido = opcoes[opcaoEscolhida];
        menuASerExibido.Executar(bandasRegistradas);
        Console.Clear();
      }
    }
  }
}