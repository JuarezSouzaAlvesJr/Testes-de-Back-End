using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFST2
{
    public static class CalculadoraIMC
    {
        public static double ValordoIMC(double peso, double altura)
        {
            double IMC = peso / (altura * altura);
            return IMC;
        }
    }

    public static class ClassificacaoIMC
    {
        public static string Categoria(double IMC)
        {
            string classificacao;

            if (IMC < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                classificacao = "Obesidade grau I";
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                classificacao = "Obesidade grau II";
            }
            else
            {
                classificacao = "Obesidade grau III";
            }

            return classificacao;
        }
    }
}
