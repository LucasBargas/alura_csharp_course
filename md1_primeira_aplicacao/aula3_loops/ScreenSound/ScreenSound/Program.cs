
// Screen Sound
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calipso" };

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
    Console.WriteLine("Bem vindo ao ScreenSound");
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
        case 3: Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}"); break;
        case 4: Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}"); break;
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
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso.");
    listaDasBandas.Add( nomeDaBanda );
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

    foreach (var banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Thread.Sleep(2000);
    Console.WriteLine("\nDigite qualquer tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

ExibirOpcoesDoMenu();
