using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuMostrarBandas : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
      Console.WriteLine($"Banda: {banda}");
    }

    Thread.Sleep(2000);
    RetornaParaOMenu();
  }
}