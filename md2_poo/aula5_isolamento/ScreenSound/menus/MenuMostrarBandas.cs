using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuMostrarBandas : Menu
{
  public void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
      Console.WriteLine($"Banda: {banda}");
    }

    Thread.Sleep(2000);
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
  }
}