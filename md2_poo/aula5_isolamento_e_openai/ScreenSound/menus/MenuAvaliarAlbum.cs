using ScreenSound.modelos;
using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuAvaliarAlbum : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    this.ExibirTituloDaOpcao("Avaliar álbum");

    Console.Write("Digite o nome da banda que deseja avaliar o álbum: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      Banda banda = bandasRegistradas[nomeDaBanda];
      System.Console.Write("Agora digite o título do álbum: ");
      string tituloDoAlbum = Console.ReadLine()!;

      if (banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
      {
        Album album = banda.Albuns.First(a => a.Nome.Equals(tituloDoAlbum));

        System.Console.Write($"Qual a nota que o álbum {tituloDoAlbum} merece: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        album.AdicionarNota(nota);

        Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloDoAlbum}");
        Thread.Sleep(2000);
        Console.Clear();
      }
      else
      {
        Console.WriteLine($"\nO álbum {tituloDoAlbum} não foi encontrado!");
        Thread.Sleep(2000);
        RetornaParaOMenu();
      }
    }
    else
    {
      VerificaSeBandaExiste(bandasRegistradas, nomeDaBanda);
    }
  }
}