using System;

namespace Git_github
{
    class Program
    {
        static void Main(string[] args)
        {
            #region base
            Console.WriteLine("Digite 1 para iniciar o programa ou digite  para sair");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("Informe o valor dos valores dos numeros a serem somados");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int resultado = Soma(a, b);
                Console.WriteLine("A soma dos valores e igual a " + Soma(a,b));
                Console.WriteLine("Se deseja repetir ou aperte 0 para sair");
                opcao = int.Parse(Console.ReadLine());

            }
            #endregion

            static int Soma(int a, int b)
            {
                return a + b;
            }
            static int Subtracao(int a, int b)
            {
                return a - b;

            }

            static int Multiplicacao(int a, int b)
            {
                return a * b;
            }
            






        }
    }
}
