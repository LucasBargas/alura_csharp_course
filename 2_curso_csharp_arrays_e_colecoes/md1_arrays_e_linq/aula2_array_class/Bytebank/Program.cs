// int idade1 = 30;
// int idade2 = 40;
// int idade3 = 17;
// int idade4 = 21;
// int idade5 = 18;

// double media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

void TestaArrayInt()
{
  // Lidando com arrays de inteiro
  int[] idades = [30, 40, 17, 21, 18];
  System.Console.WriteLine($"Tamanho do Array {idades.Length}");

  int acumulador = 0;
  for (int i = 0; i < idades.Length; i++)
  {
    System.Console.WriteLine($"Índice [{i}] = {idades[i]}");

    acumulador += idades[i];
  }

  int media = acumulador / idades.Length;
  System.Console.WriteLine($"Média das idades: {media}\n");

  // Lidando com arrays de string
  string[] arrayDePalavras = new string[5];

  for (int i = 0; i < arrayDePalavras.Length; i++)
  {
    System.Console.Write($"Digite {i + 1}ª palavra: ");
    arrayDePalavras[i] = Console.ReadLine()!;
  }

  System.Console.Write("Digite a palavra que deseja buscar: ");
  string busca = Console.ReadLine()!;

  foreach (var palavra in arrayDePalavras)
  {
    if(palavra.Equals(busca))
    {
      System.Console.WriteLine($"A palavra {busca} consta como registrada");
      return;
    }

    System.Console.WriteLine($"A palavra {busca} não foi localizada.");
    return;
  }
}

TestaArrayInt();