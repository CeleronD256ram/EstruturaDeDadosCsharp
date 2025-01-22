using EstruturaDeDadosCsharp.ordenacao;

int opcao;
do
{
    
    ExibirMenu();


    string entrada = Console.ReadLine();
    if (!int.TryParse(entrada, out opcao) || opcao < 0)
    {
        Console.WriteLine("Opção inválida. Tente novamente.\n");
        continue;
    }

    
    switch (opcao)
    {
        case 1:
            TestarQuickSort();
            break;
        
        case 2:
            TestarBubbleSort();
            break;

        case 0:
            Console.WriteLine("Encerrando o programa...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

} while (opcao != 0);


void ExibirMenu()
{
    Console.WriteLine("#########################################################");
    Console.WriteLine("         QUAL ESTRUTURA DE DADOS DESEJA TESTAR?          ");
    Console.WriteLine("#########################################################");
    Console.WriteLine("1- QuickSort.");
    Console.WriteLine("2- BubbleSort.");
    Console.WriteLine("0- Sair.");
    Console.Write("\nDigite o número correspondente: ");
}


/// Testa a implementação do QuickSort.
void TestarQuickSort()
{
    int[] arrayPraTeste = { 21, 12, 43, 0, 5, 21, 7, 654, 54, 80 };

    Console.WriteLine("\nAntes da ordenação:");
    foreach (var item in arrayPraTeste)
    {
        Console.Write(item + " ");
    }

    // Chama o método de ordenação
    QuickSort.OrdenarQuickSort(arrayPraTeste, 0, arrayPraTeste.Length - 1);

    Console.WriteLine("\n\nArray ordenado:");
    foreach (var item in arrayPraTeste) { Console.Write(item + " "); }
   
    Console.WriteLine();
}

//testar bubbleSort
void TestarBubbleSort()
{
    decimal[] precos = { 1238, 50, 504, 80, 725, 50, 68, 190, 90 };
    Console.WriteLine("\nAntes da ordenação:");
    foreach (var item in precos) { Console.Write(item + " "); }
    
    BubbleSort.OrdenarBubble(precos);
    
    Console.WriteLine("\n\nArray ordenado:");
    foreach (var item in precos) { Console.Write(item + " "); }

    Console.WriteLine();


}
