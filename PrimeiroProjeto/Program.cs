// Screen Sound
using System.Drawing;

string mensagemDeBoasVindas = "Boas vindas Screen Sound";
//List<string> listaNomeBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Pink Floyd", new List<int>{8, 10, 9, 8});
bandasRegistradas.Add("Calypso", new List<int>{9,4,5});
bandasRegistradas.Add("The Beatles", new List<int>());


void ExibirLogo() 
{
    Console.WriteLine(@"
            
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu() 
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\n Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInt)
    {
        case 1: 
            ResgistrarBandas();
            break;

        case 2:
            MostrarBadasRegistradas();
            break;

        case 3:
            AvaliarBanda();
            break;

        case 4:
            MediaAvaliacoes();
            break;

        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }


}

void ResgistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar Banda");
    Console.WriteLine("Digite o nome da banda que deseja registrar: \n");
    string nomeDaBada = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBada, new List<int>());
    Console.WriteLine($"A banda {nomeDaBada} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();

}

void MostrarBadasRegistradas() 
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    /*
    for (int i = 0; i < listaNomeBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaNomeBandas[i]}");
    }
    */

    foreach (string banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nAperte qualaquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();

}

void AvaliarBanda() 
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual nota a {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota,{nota}, da {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else 
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadLine();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}


void MediaAvaliacoes()
{
    ExibirTituloDaOpcao("Médida de Avaliações");
    Console.WriteLine("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasBandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média das avaçiações é {somarNotas(notasBandas)}");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}


void ExibirTituloDaOpcao(string titulo) 
{
    int qtdLetras = titulo.Length + 2;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '-');
    Console.WriteLine("*" + asteriscos + "*");
    Console.WriteLine("| " + titulo + " |");
    Console.WriteLine("*" + asteriscos + "*\n");
}

int somarNotas(List<int> valor)
{
    int soma = 0;
    for (int i = 0; i < valor.Count; i++) 
    {
        soma = soma + valor[i];
    }

    soma = mediaDaSomaNotas(soma, valor);

    return soma;
}
int mediaDaSomaNotas(int valorado, List<int> valor) 
{
   return valorado = valorado / valor.Count;
}

ExibirOpcoesMenu();




