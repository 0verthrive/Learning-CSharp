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
                Console.WriteLine("5 - Verificando sinal");
                Console.WriteLine("6 - Par ou ímpar");
                Console.WriteLine("7 - Múltiplos");
                Console.WriteLine("8 - Duração do jogo");
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
                    case 5 :
                        Console.WriteLine("Informe um valor: ");
                        double comparativo = double.Parse(Console.ReadLine());

                        if(comparativo < 0)
                        {
                            Console.WriteLine("O valor {0} é negativo", comparativo);
                        }
                        else
                        {
                            Console.WriteLine("O valor {0} é positivo", comparativo);
                        }
                        break;
                    case 6 :
                        Console.WriteLine("Informe um valor: ");
                        double aux = double.Parse(Console.ReadLine());
                        if(aux %2 == 0)
                        {
                            Console.WriteLine("Valor {0} é par", aux);
                        }
                        else
                        {
                            Console.WriteLine("Valor {0} é ímpar", aux);
                        }
                        break;
                    case 7 :
                        Console.WriteLine("Informe dois números inteiros: ");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        float result;
                        int auxiliar;

                        if(num1 > num2) 
                        { 
                            result = (float)num1/num2;
                        }
                        else
                        {
                            result = (float)num2/num1;
                        }

                        auxiliar = (int)result;

                        if(auxiliar == result)
                        {
                            Console.WriteLine("São múltiplos");
                        }
                        else
                        {
                            Console.WriteLine("Não são múltiplos");
                        }
                        break;
                    case 8 :
                        Console.WriteLine("Informe a hora inicial: ");
                        int inicio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a hora final: ");
                        int fim = int.Parse(Console.ReadLine());
                        int duracao;

                        if(inicio < fim)
                        {
                            duracao = inicio - fim;
                        }
                        else
                        {
                            duracao = 24 - inicio + fim;
                        }

                        Console.WriteLine("O jogo durou: {0}h", duracao);

                        break;
                }
            } while (opc != 0);

        }
    }
}
