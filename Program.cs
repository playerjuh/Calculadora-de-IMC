using System;
using System.Globalization; // Importante para garantir a leitura correta dos números

class Program
{
    static void Main()
    {

        string continuar;
        do
        {
            double IMC;

            Console.Write("Ola usuario! Qual e o seu nome? ");
            string nome = Console.ReadLine();

            int idade;
            while (true)
            {
                Console.Write("Qual sua idade? ");
                if (int.TryParse(Console.ReadLine(), out idade))
                    break;
                Console.WriteLine("Por favor, digite um numero valido para a idade. Ex: 25");
            }

            double altura;
            while (true)
            {
                Console.Write("Qual sua altura? (Use ponto, ex: 1.73): ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out altura))
                    break;
                Console.WriteLine("Por favor, digite um numero valido para a altura. Ex: 1.73");
            }

            double peso;
            while (true)
            {
                Console.Write("Qual seu peso? (Use ponto, ex: 70.5): ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
                    break;
                Console.WriteLine("Por favor, digite um numero valido para o peso. Ex: 86");
            }

            IMC = peso / (altura * altura);

            Console.WriteLine("");
            Console.WriteLine($"Ola {nome}! Voce tem {idade} anos e {altura:F2}m de altura. Seu IMC e de {IMC:F2}.");

            if (IMC < 18.5)
            {

                Console.WriteLine("Voce esta abaixo do peso.");
            }

            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Voce esta no peso ideal, parabens!");
            }

            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Console.WriteLine("Voce esta com sobrepeso.");
            }
            else
            {
                Console.WriteLine("Voce esta na faixa da obesidade.");
            }
            

            Console.WriteLine("");
            Console.Write("Voce deseja calcular mais um IMC? (s/n): ");
            continuar = Console.ReadLine().ToLower();
            Console.WriteLine("");

        } while (continuar == "s");
    }
}
