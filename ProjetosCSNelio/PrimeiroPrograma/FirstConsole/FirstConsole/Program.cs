using System;
using System.Globalization;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Menu*/
            int opc;
            do
            {
                Console.WriteLine("Escolha a opção de exercício");
                Console.WriteLine("1 - Entrada e soma de valores");
                Console.WriteLine("2 - Encontrando a área do circulo");
                Console.WriteLine("3 - Diferença entre produtos");
                Console.WriteLine("4 - Calculo salarial");
                Console.WriteLine("0 - Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Informe dois valores inteiros");
                        Console.Write("1º: ");
                         int firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("2º: ");
                         int secondNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("A Soma de {0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                        break;
                    case 2:
                        Console.Write("Informe o valor do raio: ");
                        double raio = double.Parse(Console.ReadLine());
                        double pi = 3.14159, area;

                        area = pi * (raio * raio);
                        Console.WriteLine("A área do círculo com o raio de "+raio+" é = "+area.ToString("F4", CultureInfo.InvariantCulture));

                        break;
                    case 3 :
                        Console.WriteLine("Informe quatro valores inteiros");
                        Console.Write("1º: ");
                        int value1 = int.Parse(Console.ReadLine());
                        Console.Write("2º: ");
                        int value2 = int.Parse(Console.ReadLine());
                        Console.Write("3º: ");
                        int value3 = int.Parse(Console.ReadLine());
                        Console.Write("4º: ");
                        int value4 = int.Parse(Console.ReadLine());

                        int product1 = value1 * value2, product2 = value3 * value4;

                        Console.WriteLine("Primeiro produto = {0}\nSegundo produto = {1}\nDiferença = {2}", product1, product2, product1 - product2);

                        break;
                    case 4:
                        Console.WriteLine("Calculo salarial bruto");
                        Console.Write("Número do funcionário: ");
                        int matricula = int.Parse(Console.ReadLine());
                        Console.Write("Valor /h: ");
                        double porHora= double.Parse(Console.ReadLine());
                        Console.Write("Horas trabalhadas: ");
                        int horasTrab = int.Parse(Console.ReadLine());

                        double salario = porHora * horasTrab;

                        Console.WriteLine("Matricula: {0}\nSalário a receber = {1:F2}", matricula, salario);

                        break;
                }
            } while (opc != 0);

        }
    }
}
