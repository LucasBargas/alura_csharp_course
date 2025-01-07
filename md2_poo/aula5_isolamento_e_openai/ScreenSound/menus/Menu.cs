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

  public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
  }
}