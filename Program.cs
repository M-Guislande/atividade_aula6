using System;

internal class Program
{
    static string membro1 = "Sem cadastro", membro2 = "Sem cadastro", membro3 = "Sem cadastro";
    static string nome1 = "Sem cadastro", nome2 = "Sem cadastro", nome3 = "Sem cadastro", nome4 = "Sem cadastro", nome5 = "Sem cadastro";
    static string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
    static int pont1 = -1, pont2 = -1, pont3 = -1, pont4 = -1, pont5 = -1;
    static int quant = 0;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU MARVEL =====");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Quantos heróis você deseja cadastrar? (máximo 5): ");
                    quant = int.Parse(Console.ReadLine());
                    if (quant > 5) quant = 5;
                    cadastrarHeroi(quant);
                    break;

                case 2:
                    selecionarEquipe(quant);
                    break;

                case 3:
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 4);
    }

    static void cadastrarHeroi(int quant)
    {
        for (int i = 1; i <= quant; i++)
        {
            Console.WriteLine($"\nCadastro do Herói #{i}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Poder: ");
            string poder = Console.ReadLine();

            Console.Write("Pontuação (0 a 10): ");
            int pontuacao = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    nome1 = nome; poder1 = poder; pont1 = pontuacao;
                    break;
                case 2:
                    nome2 = nome; poder2 = poder; pont2 = pontuacao;
                    break;
                case 3:
                    nome3 = nome; poder3 = poder; pont3 = pontuacao;
                    break;
                case 4:
                    nome4 = nome; poder4 = poder; pont4 = pontuacao;
                    break;
                case 5:
                    nome5 = nome; poder5 = poder; pont5 = pontuacao;
                    break;
            }
        }
    }

    static void selecionarEquipe(int quant)
    {
        if (quant < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis para formar uma equipe.");
            return;
        }

        Console.WriteLine("\nEscolha 3 heróis para sua equipe:");

        exibirHerois();

        Console.Write("Escolha o 1º herói (1-5): ");
        membro1 = escolherHeroi(int.Parse(Console.ReadLine()));

        Console.Write("Escolha o 2º herói (1-5): ");
        membro2 = escolherHeroi(int.Parse(Console.ReadLine()));

        Console.Write("Escolha o 3º herói (1-5): ");
        membro3 = escolherHeroi(int.Parse(Console.ReadLine()));
    }

    static string escolherHeroi(int escolha)
    {
        switch (escolha)
        {
            case 1: return nome1;
            case 2: return nome2;
            case 3: return nome3;
            case 4: return nome4;
            case 5: return nome5;
            default: return "Inválido";
        }
    }

    static int pegarPontuacao(string nome)
    {
        if (nome == nome1) return pont1;
        if (nome == nome2) return pont2;
        if (nome == nome3) return pont3;
        if (nome == nome4) return pont4;
        if (nome == nome5) return pont5;
        return 0;
    }

    static string pegarPoder(string nome)
    {
        if (nome == nome1) return poder1;
        if (nome == nome2) return poder2;
        if (nome == nome3) return poder3;
        if (nome == nome4) return poder4;
        if (nome == nome5) return poder5;
        return "";
    }

    static int calcularPontuacaoTotal()
    {
        return pegarPontuacao(membro1) + pegarPontuacao(membro2) + pegarPontuacao(membro3);
    }

    static void exibirEquipe()
    {
        Console.WriteLine("\n===== Equipe Selecionada =====");
        Console.WriteLine($"{membro1} - Poder: {pegarPoder(membro1)} - Pontuação: {pegarPontuacao(membro1)}");
        Console.WriteLine($"{membro2} - Poder: {pegarPoder(membro2)} - Pontuação: {pegarPontuacao(membro2)}");
        Console.WriteLine($"{membro3} - Poder: {pegarPoder(membro3)} - Pontuação: {pegarPontuacao(membro3)}");

        Console.WriteLine($"\nPontuação total da equipe: {calcularPontuacaoTotal()}");
    }

    static void exibirHerois()
    {
        Console.WriteLine($"1 - {nome1}");
        Console.WriteLine($"2 - {nome2}");
        Console.WriteLine($"3 - {nome3}");
        Console.WriteLine($"4 - {nome4}");
        Console.WriteLine($"5 - {nome5}");
    }
}
