using System.Threading.Channels;

namespace Calculadora.Calculadora
{
    internal class ValoresOperacao
    {
        private List<double> valores { get; set; }

        public ValoresOperacao() { }
        public ValoresOperacao(List<double> valores) { this.valores = valores; }

        public List<double> getValores() { return this.valores; }

        public void setValores(double valor) { this.valores.Add(valor); } 

        public void limpaValores()
        {
            this.valores.Clear();
        }
    }           
}
