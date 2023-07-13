
using Calculadora.Adicao;
using Calculadora.Calculadora;
using Calculadora.Operacao;
using Calculadora.Divisao;
using Calculadora.Multiplicacao;
using Calculadora.Subtracao;
using System.Data;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] opcoes = { "1 - SOMA", "2 - SUBTRACAO", "3 - DIVISAO", "4 - MULTIPLICACAO", "5 - SAIR" };

        List<double> valores = new List<double>();

        ValoresOperacao valoresOperacao = new ValoresOperacao(valores);

        while (true)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("CALCULADORA MASTER");
            Console.WriteLine("-----------------------------");
            foreach (string opcao in opcoes) { Console.WriteLine(opcao); }
            Console.Write("DIGITE: ");

            byte operacao = byte.Parse(s: Console.ReadLine());
            if (operacao == 5) break;
            for (int i = 1; i <= 2; i++) { Console.Write($"{i} - Valor: "); valoresOperacao.setValores(double.Parse(s: Console.ReadLine())); }

            var listaValores = valoresOperacao.getValores();

            double result;

            switch (operacao)
            {
                case (byte)TipoOperacao.SOMA:
                    Adicao adicao = new Adicao();
                    result = adicao.soma(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{TipoOperacao.SOMA}: {result}");

                    break;
                case (byte)TipoOperacao.SUBTRACAO:
                    Subtracao subtracao = new Subtracao();
                    result = subtracao.diminuir(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{TipoOperacao.SUBTRACAO}: {result}");
                    break;
                case (byte)TipoOperacao.DIVISAO:
                    Divisao divisao = new Divisao();
                    result = divisao.divisao(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{TipoOperacao.DIVISAO}: {result}");
                    break;
                case (byte)TipoOperacao.MULTIPLICACAO:
                    Multiplicacao multiplicacao = new Multiplicacao();
                    result = multiplicacao.multiplicacao(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{TipoOperacao.MULTIPLICACAO}: {result}");
                    break;
                case (byte)TipoOperacao.SAIR:
                    break;
                default: Console.WriteLine("Erro: Por Favor! Digite de 1 ao 5."); break;
            }
            Console.ReadKey();
            valoresOperacao.limpaValores();
            Console.Clear();

            Console.WriteLine("Deseja realizar uma nova operacao:\n1 - SIM\n2 - NAO");
            Console.Write("Digite: ");
            byte continuar = byte.Parse(Console.ReadLine());

            if (continuar == 2) break;

        }
    }
}