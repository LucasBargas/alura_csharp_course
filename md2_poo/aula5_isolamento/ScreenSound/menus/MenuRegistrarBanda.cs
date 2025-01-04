
using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuRegistrarBanda : Menu
{
  internal void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      Console.Write($"Já exite uma banda com o nome {nomeDaBanda} registrada!");
    }
    else
    {
      bandasRegistradas.Add(nomeDaBanda, new Banda(nomeDaBanda));
      Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }

    Thread.Sleep(4000);
    Console.Clear();
  }
}