
// Screen Sound
// List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calipso" };

// Dicionario onde armazena o nome da banda, string, e aa notas, inteiro, de cada uma.
using System.Security.AccessControl;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 7, 6, 8 });
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirLogo()
{
    // Exibição do nome do app
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Bem vindo ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDgite 1 para registrar uma banda:");
    Console.WriteLine("Dgite 2 para mostrar todas as bandas:");
    Console.WriteLine("Dgite 3 para avaliar uma banda:");
    Console.WriteLine("Digite 4 para exibir a média da banda:");
    Console.WriteLine("Digite -1 para sair:");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    // Convertendo string em um numero inteiro
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica) 
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: AvaliarUmaBanda(); break;
        case 4: ExibirMedia(); break;
        case -1: Console.WriteLine("Tchau tchau :)"); break;
        default: Console.WriteLine("Opção inválida."); break;
    }
}

void RegistrarBanda()
{   
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Thread.Sleep(2000);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso.");
    // listaDasBandas.Add( nomeDaBanda );
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas:");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    RetornarParaOMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");

    // Digite qual banda deseja avaliar
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    // Verifica se a banda existe no dicionario e, se sim, atribuir nota
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);

        Thread.Sleep(2000);
        Console.WriteLine($"\nA nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso!");
        RetornarParaOMenu();
    }
    else // senão, volta ao menu principal
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi localizada.");
        RetornarParaOMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    // Digite qual banda deseja pegar a média
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas [nomeDaBanda];

        Thread.Sleep(2000);
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {notasDaBanda.Average()}");
        RetornarParaOMenu();
    }
    else // senão, volta ao menu principal
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi localizada.");
        RetornarParaOMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void RetornarParaOMenu()
{
    Thread.Sleep(2000);
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
