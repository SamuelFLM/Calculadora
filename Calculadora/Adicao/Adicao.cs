using Calculadora.Calculadora;

namespace Calculadora.Adicao
{
    public class Adicao : IAdicao
    {
        public double soma(double valor1, double valor2)
        {
            return (double)(valor1 + valor2);
        }
    }
}
