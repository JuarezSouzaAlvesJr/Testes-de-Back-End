namespace ProjetoTesteFST2
{
    public static class Calculadora //classe estática para não precisar criar instâncias do objeto para acessar o método criado; o método não precisa ser declarado com estático.
    {
        public static double Somar(double PrimeiroNum, double SegundoNum)
        {
            return (PrimeiroNum + SegundoNum);
        }
    }
}