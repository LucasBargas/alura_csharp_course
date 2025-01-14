using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class Menu
{
  public void ExibirTituloDaOpcao(string titulo)
  {
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
  }

  public void RetornaParaOMenu()
  {
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
  }

  public void VerificaSeBandaExiste(Dictionary<string, Banda> bandasRegistradas, string nomeDaBanda)
  {
    Dictionary<int, Menu> opcoes = new()

    {
      {1, new MenuRegistrarBanda()},
      {-1, new MenuSair()},
    };

    System.Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    System.Console.WriteLine($"\nDeseja registrar a banda {nomeDaBanda}?");

    System.Console.WriteLine($"\nDigite 1 para registrar a banda {nomeDaBanda}");
    System.Console.WriteLine("Digite -1 para voltar ao menu principal");

    System.Console.WriteLine("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
      Menu menuASerExibido = opcoes[opcaoEscolhida];
      menuASerExibido.Executar(bandasRegistradas);
      System.Console.Clear();
    }
  }

  public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
  }
}