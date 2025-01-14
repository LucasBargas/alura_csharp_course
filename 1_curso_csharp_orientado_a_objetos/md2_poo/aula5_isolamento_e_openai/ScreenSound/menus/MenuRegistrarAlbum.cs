using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuRegistrarAlbum : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Registro de álbuns");

    System.Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = System.Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      System.Console.Write("Agora digite o título do álbum: ");
      string tituloAlbum = System.Console.ReadLine()!;

      Banda banda = bandasRegistradas[nomeDaBanda];

      if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
      {
        System.Console.Write($"O album {tituloAlbum} já consta como registrado na banda {nomeDaBanda}");
        Thread.Sleep(4000);
        System.Console.Clear();
      }
      else
      {
        banda.AdicionarAlbum(new Album(tituloAlbum));
        System.Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        System.Console.Clear();
      }
    }
    else
    {
      VerificaSeBandaExiste(bandasRegistradas, nomeDaBanda);
    }
  }
}