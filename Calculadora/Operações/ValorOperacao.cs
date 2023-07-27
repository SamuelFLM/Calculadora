namespace Calculadora.Operações
{
    internal class ValorOperacao
    {
        private List<double> valores { get; set; }

        public ValorOperacao() { }
        public ValorOperacao(List<double> valores) { this.valores = valores; }

        public List<double> getValores() { return valores; }

        public void setValores(double valor) { valores.Add(valor); }

        public void limpaValores()
        {
            valores.Clear();
        }
    }
}
