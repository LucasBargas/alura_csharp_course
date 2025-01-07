
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
      chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo formal!");

      string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
      banda.Resumo = resposta;

      Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
      RetornaParaOMenu();
    }

    // Thread.Sleep(4000);a
    Console.Clear();
  }
}