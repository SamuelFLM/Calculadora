using System.Data;
using System;
using Calculadora.Operações.Adicao;
using Calculadora.Operações.Divisao;
using Calculadora.Operações.Multiplicacao;
using Calculadora.Operações.Subtracao;
using Calculadora.Operações;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] opcoes = { "1 - SOMA", "2 - SUBTRACAO", "3 - DIVISAO", "4 - MULTIPLICACAO", "5 - SAIR" };

        List<double> valores = new List<double>();

        ValorOperacao valoresOperacao = new ValorOperacao(valores);

        while (true)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("CALCULADORA MASTER");
            Console.WriteLine("-----------------------------");
            foreach (string opcao in opcoes) { Console.WriteLine(opcao); }
            Console.Write("\nDIGITE: ");

            byte operacao = byte.Parse(s: Console.ReadLine());
            if (operacao == 5) break;
            for (int i = 1; i <= 2; i++) { Console.Write($"{i} - Valor: "); valoresOperacao.setValores(double.Parse(s: Console.ReadLine())); }

            var listaValores = valoresOperacao.getValores();

            double result;

            switch (operacao)
            {
                case (byte)EnumOperacao.SOMA:
                    Adicao adicao = new Adicao();
                    result = adicao.soma(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{EnumOperacao.SOMA}: {result}");

                    break;
                case (byte)EnumOperacao.SUBTRACAO:
                    Subtracao subtracao = new Subtracao();
                    result = subtracao.diminuir(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{EnumOperacao.SUBTRACAO}: {result}");
                    break;
                case (byte)EnumOperacao.DIVISAO:
                    Divisao divisao = new Divisao();
                    result = divisao.divisao(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{EnumOperacao.DIVISAO}: {result}");
                    break;
                case (byte)EnumOperacao.MULTIPLICACAO:
                    Multiplicacao multiplicacao = new Multiplicacao();
                    result = multiplicacao.multiplicacao(listaValores[0], listaValores[1]);
                    Console.WriteLine($"{EnumOperacao.MULTIPLICACAO}: {result}");
                    break;
                case (byte)EnumOperacao.SAIR:
                    break;
                default: Console.WriteLine("\nErro: Por Favor! Digite de 1 ao 5."); break;
            }
            Console.ReadKey();
            valoresOperacao.limpaValores();
            Console.Clear();

            Console.WriteLine("\nDeseja realizar uma nova operacao:\n1 - SIM\n2 - NAO");
            Console.Write("\nDigite: ");
            byte continuar = byte.Parse(Console.ReadLine());

            if (continuar == 2) break;

        }
    }
}