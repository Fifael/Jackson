namespace Namespaceprogram
{
    public class Lista2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Saber se foi aprovado");
            Console.WriteLine("2 - Saber o mes");
            Console.WriteLine("3 - Jogo da forca");
            Console.WriteLine("4 - Tabuada");
            Console.WriteLine("5 - Imprimir letra por letra");
            Console.WriteLine("6 - quinhentos");
            Console.WriteLine("7 - Notas");
            Console.WriteLine("8 - Fatorial");
            Console.WriteLine("9 - Imc");
            Console.WriteLine("10 - Crie um programa que receba dois valores e solicite a operação a ser realizada (+ - * /). Ao final imprima o resultado");

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
                        Media();
                    break;

                    case 2:
                        Area();
                    break;

                    case 3:
                        Forca();
                    break;

                    case 4:
                        Tabuada();
                    break;

                    case 5:
                        ImprimirLetra();
                    break;

                    case 6:
                        quinhentos();
                    break;

                    case 7:
                        Notas();
                    break;

                    case 8:
                        Fatorial();
                    break;

                    case 9:
                        Imc();
                    break;
/*
                    case 10:
                        testes();
                    break;*/

                    default:
                        Console.WriteLine("Opção não disponível");
                        break;
                }
            } while (menu != 0);
        }

        public static void Media () // Crie um programa que receba três notas calcule a média e diga se foi aprovado (`(nota1 + nota2 + nota3 / 3)`) e (`média maior que 7 para ser aprovado`).
        {
            System.Console.WriteLine("Qual a primeira nota");
            int nota1 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a segunda nota");
            int nota2 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a terceira nota");
            int nota3 = Int32.Parse(Console.ReadLine());
            float media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                System.Console.WriteLine("Parabens voce foi aprovado");
            }
            else
            {
                System.Console.WriteLine("Voce foi repovado");
            }
        }

        public static void Area()
        {
            System.Console.WriteLine("Que mes representa esse numero");
            System.Console.WriteLine("Informe un numero de 1 a 12:");
            int mes = Int32.Parse(Console.ReadLine());

            if (mes > 12)
            {
                System.Console.WriteLine("Erro!!! Informe um numero de 1 a 12");
            }
            else if (mes == 1)
            {
                System.Console.WriteLine("Numero se refera a Janeiro");
            }
            else if (mes == 2)
            {
                System.Console.WriteLine("Numero se refera a Fevereiro");
            }
            else if (mes == 3)
            {
                System.Console.WriteLine("Numero se refera a Março");
            }
            else if (mes == 4)
            {
                System.Console.WriteLine("Numero se refera a Abril");
            }
            else if (mes == 5)
            {
                System.Console.WriteLine("Numero se refera a Maio");
            }
            else if (mes == 6)
            {
                System.Console.WriteLine("Numero se refera a Junho");
            }
            else if (mes == 7)
            {
                System.Console.WriteLine("Numero se refera a Julho");
            }
            else if (mes == 8)
            {
                System.Console.WriteLine("Numero se refera a Agosto");
            }
            else if (mes == 9)
            {
                System.Console.WriteLine("Numero se refera a Setembro");
            }
            else if (mes == 10)
            {
                System.Console.WriteLine("Numero se refera a Outubro");
            }
            else if (mes == 11)
            {
                System.Console.WriteLine("Numero se refera a Novembro");
            }
            else if (mes == 12)
            {
                System.Console.WriteLine("Numero se refera a Dezembro");
            }
        }

        public static void Forca()
        {

        }

        public static void Tabuada ()
        {  
            System.Console.WriteLine("Tabuada de 0 a 10 mais rapida do mundo:");
            System.Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                System.Console.WriteLine($"\nTabuada do {i}\n");
                System.Console.WriteLine();

                for (int j = 0; j <= 10; j++)
                {
                    System.Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    
        public static void ImprimirLetra()
        {
            System.Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            foreach (char letra in frase)
            {
                System.Console.WriteLine($"\n {letra}");
            }
        }

        public static void quinhentos()
        {

        }

        public static void Notas()
        {
            double nota;
            double soma = 0;
            int contador = 0;
            System.Console.WriteLine("Fazer a Media só quando a nota for negativa");
            System.Console.WriteLine("nota");
            do
            {
                nota = Double.Parse(Console.ReadLine());
                
                if (nota >= 0)
                {
                    soma += nota;
                    contador++;
                }
            } while (nota >= 0);
            Console.WriteLine($"A média das notas é: {soma / contador} ");
        }

        public static void Fatorial() {
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());
            int result = CalculateFactorial(num);
            Console.WriteLine("O fatorial de " + num + " é " + result);
        }

        static int CalculateFactorial(int n){
            int result = 1;
            Console.Write($"{n}! = "); // 3! =
            for (int i = n; i >= 1; i--)
            {
                result = result * i;
                string operation = i == 1 ? " = " : " x " ;
                Console.Write($"{i}{operation}"); // 3! = 3 x 2 x 1 = 6
            }
            Console.Write($"{result}");
            Console.WriteLine("");
            return result;
        }
    
        public static void Imc()
        {
            System.Console.WriteLine("Imc");
            System.Console.WriteLine("Digite seu peso");
            double peso = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua Altura");
            double altura = Double.Parse(Console.ReadLine());
            double imc = (peso / (altura * altura));
            /*
            Abaixo de 18,5 | Abaixo do Peso
            Entre 18,6 e 24,9 | Peso Ideal
            Entre 25,0 e 29,9 | Levemente acima do peso
            Entre 30,0 e 34,9 | Obesidade Grau I
            Entre 35,0 e 39,9 | Obesidade Grau II
            Acima de 40 | Obesidade Grau III (mórbida)
            */

            if (imc < 18.5)
            {
                System.Console.WriteLine("\nAbaixo do Peso");
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                System.Console.WriteLine("\nPeso Ideal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                System.Console.WriteLine("\nLevemente acima do peso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                System.Console.WriteLine("\nObesidade Grau I");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                System.Console.WriteLine("\nObesidade Grau II");
            }
            else if (imc > 40)
            {
                System.Console.WriteLine("\nObesidade Grau III (mórbida)");
            }
            System.Console.WriteLine($"\n{imc}");

        }

    }
}
