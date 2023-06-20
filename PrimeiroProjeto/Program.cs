string mensagemBoasVindas = "\nBoas vindas ao Screen Sound";
//List<string> listaBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("Halestorm", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine (mensagemBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoConvertida = int.Parse(opcao);

    switch(opcaoConvertida)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: calcularMediaBanda();
            break;
        case 0:
            Console.WriteLine("Você escolheu sair da aplicação");
            break;
        default: Console.WriteLine("Opção inválida");
            Thread.Sleep(1000);
            Console.Clear();
            ExibirMenu();
            break;
    }
}
ExibirMenu();

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Lista de Bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione uma tecla para retornar para o menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar Banda");
    Console.Write("Que banda deseja avaliar? ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Que nota gostaria de dar para a banda {nomeBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("Pressione uma tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void calcularMediaBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Média da Banda");
    Console.Write("Deseja visualizar a média de qual banda? ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasBanda = bandasRegistradas[nomeBanda];
        if (notasBanda.Count > 0)
        {
            double mediaNota = bandasRegistradas[nomeBanda].Average();
            Console.WriteLine($"A média da banda {nomeBanda} é {mediaNota}.");
            Console.WriteLine("Pressione uma tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            ExibirMenu();
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} ainda não foi avaliada. Deseja registrar uma avaliação? (S/N) ");
            string resposta = Console.ReadLine()!;
            if(resposta == "S" || resposta == "s")
            {
                Console.Clear();
                AvaliarBanda();
            }
            else
            {
                Console.Clear();
                ExibirMenu();
            }

        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("Pressione uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

//https://github.com/alura-cursos/jogoCSharp