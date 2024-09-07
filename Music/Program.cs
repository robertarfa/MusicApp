﻿using Music.Modelos;

Banda ira = new Banda("Ira");
Banda beatles = new("Beatles");


// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "Beatles" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int> { 10, 9, 7 });
void ExibirMensagemDeBoasVindas()
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

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    //Quando não quer que seja nulo coloca uma exclamação no final.
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();

        ExibirTituloDaOpcao("Registro de bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        //listaDasBandas.Add(nomeDaBanda.ToString());

        bandasRegistradas.Add(nomeDaBanda.ToString(), new List<int>());

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();

        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();

        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

        //for (int i = 0; i < listaDasBandas.Count; i++)
        //{
        //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}

        //foreach (string banda in listaDasBandas)
        //{
        //    Console.WriteLine($"Banda: {banda}");
        //}

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    // ...

    void AvaliarUmaBanda()
    {
        //digite qual banda deseja avaliar
        // se a banda existir no dicionario >> atribuir uma nota
        // senão, volta ao menu principal

        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");

        string nomeDaBanda = Console.ReadLine()!;
        //Exclamação para ser uma string e não um valor nulo 

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    void ExibirMedia()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir média da banda");
        Console.Write("Qual banda você deseja ver a média de notas? ");

        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            //var media = 0;
            //var somarNotas = 0;

            //for (int i = 0; i < bandasRegistradas[nomeDaBanda].Count; i++)
            //{
            //    somarNotas = somarNotas + bandasRegistradas[nomeDaBanda][i];
            //}

            //media = somarNotas / bandasRegistradas[nomeDaBanda].Count;

            List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];

            Console.WriteLine($"\nA média de notas da banda {nomeDaBanda} é {notasDaBanda.Average()}.");

            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();

            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    // ...
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();