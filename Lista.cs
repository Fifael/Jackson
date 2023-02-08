// See https://aka.ms/new-console-template for more information
namespace Namespaceprogram
{
    public class Lista
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - calcule a média");
            Console.WriteLine("2 - calcule a área");
            Console.WriteLine("3 - calcule o volume");
            Console.WriteLine("4 - Maior que o dobro");
            Console.WriteLine("5 - calcule _bhaskara_");
            Console.WriteLine("6 - calcule a velocidade média de uma viagem");
            Console.WriteLine("7 - calculo do percentual de imposto pago");
            Console.WriteLine("8 - teste se um valor é par ou ímpar");
            Console.WriteLine("9 - compare dois valores Strings");
            Console.WriteLine("10 - testes");
            Console.WriteLine("11 - testes");

            int menu = 0;
            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        media();
                        break;
                    case 2:
                        area();
                        break;
                    case 3:
                        volume();
                        break;
                    case 4:
                        maior();
                        break;
                    case 5:
                        bhaskara();
                        break;
                    default:
                        Console.WriteLine("Opção não disponível");
                        break;
                }
            } while (menu != 0);
        }


        public static void media()
        {
            System.Console.WriteLine("Qual a primeira nota");
            int nota1 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a segunda nota");
            int nota2 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a terceira nota");
            int nota3 = Int32.Parse(Console.ReadLine());
            float media = (nota1 + nota2 + nota3) / 3;
            System.Console.WriteLine($"Primeira nota: {nota1} \nSegunda nota: {nota2} \nTerceira nota: {nota3} \nMedia: {media}");
        }

        public static void area()
        {
            System.Console.WriteLine("Calculo de area");
            System.Console.WriteLine("Quando de altura");
            double altura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual de largura");
            double largura = Double.Parse(Console.ReadLine());
            double area = (altura * largura);
            System.Console.WriteLine($"Area: {area}");
        }

        public static void volume()
        {
            System.Console.WriteLine("Calculo de volume");
            System.Console.WriteLine("Qual a largura");
            double largura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a Altura");
            double altura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a Profundidade");
            double profundidade = Double.Parse(Console.ReadLine());
            double volume = (largura * altura * profundidade);
            System.Console.WriteLine($"O volume é {volume}");
        }

        public static void maior()
        {
            System.Console.WriteLine("Calculo de maior numero");
            System.Console.WriteLine("Primeiro numero");
            double numero1 = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo numero");
            double numero2 = Double.Parse(Console.ReadLine());
            double numero3 = (numero2 * 2);

            if (numero1 > numero3)
            {
                System.Console.WriteLine("\nO primeiro numero que o dobro do segundo:\n");
            }
            else
            {
                System.Console.WriteLine("\nO dobro do segundo numero e maior que o primeiro numero:\n");
            }
        }

        public static void bhaskara()
        {
            Console.WriteLine("bhaskara");
            Console.Write("A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            double c = double.Parse(Console.ReadLine());

            double operador = (b * b - 4 * a * c);

            if (operador < 0)
            {
            Console.WriteLine("Delta não pode ser menor que 0.");
            }
            else
            {
            double xlinha = (-b + Math.Sqrt(operador)) / (2 * a);
            double x2linhas = (-b - Math.Sqrt(operador)) / (2 * a);
            Console.WriteLine($"As raízes da equação são x1: {xlinha} e x2 = {x2linhas}");
            }
        }

        

    }
}



