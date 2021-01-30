namespace Secao4_ConversorDeMoedas
{
    class ConversorDeMoeda
    {
        public static double iof = 6.0;
        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = quantia * cotacao;
            return total + total * iof / 100;
        }
    }
}
