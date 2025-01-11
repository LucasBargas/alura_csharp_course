
using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.menus;

internal class MenuRegistrarBanda : Menu
{
  public override void Executar(Dictionary<string, Banda> bandasRegistradas)
  {
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; 
    Banda banda = new(nomeDaBanda);
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
      Console.Write($"Já exite uma banda com o nome {nomeDaBanda} registrada!");
    }
    else
    {
      bandasRegistradas.Add(nomeDaBanda, banda);

      OpenAIAPI client = new("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");

      var chat = client.Chat.CreateConversation();
      chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal!");

      string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
      banda.Resumo = resposta;

      Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
      RetornaParaOMenu();
    }

    // Thread.Sleep(4000);a
    Console.Clear();
  }
}