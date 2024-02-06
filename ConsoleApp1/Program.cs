using System;
using System.Globalization;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa, conforme exemplos.*/

            int N1, N2, Soma;
            Console.WriteLine("Digite um número");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");
            N2 = int.Parse(Console.ReadLine());
            Soma = N1 + N2;
            Soma = N1 + N2;
            Console.WriteLine("A soma é " + Soma);

            //Exercicio 2
            /*
             * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159*/

            double Raio = 3.14159;
            int raio2;
            Console.WriteLine("Digite o numero: ");
            raio2= int.Parse(Console.ReadLine());
            double area = Raio * raio2;
            Console.WriteLine("A área do circulo é " + area.ToString("F4"));

            //Exercicio 3
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
            int A, B, C, D;
            Console.WriteLine("Digite 4 numeros: ");
            A= int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B) - (C * D);
            Console.WriteLine("A diferença eh " + DIFERENCA);

            //Exercicio 4
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
            decimais.*/
            int NumFuncionario, Horas;
            float ValorHoras, Salario;

            Console.WriteLine("Digite respectivamente: o Numero do funcionario, o numero de horas trabalhadas e o valor que recebe por hora");
            NumFuncionario= int.Parse(Console.ReadLine());
            Horas= int.Parse(Console.ReadLine());
            ValorHoras= float.Parse(Console.ReadLine());

            Console.WriteLine("Numero do funcionario: " + NumFuncionario);
            Salario=Horas*ValorHoras;
            Console.WriteLine("Salario a receber: " +  Salario.ToString("F2"));

            //Exercicio 5
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de   uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago*/
            int Cod1, Cod2, qnt1, qnt2;
            double preco1, preco2, total;

            //Armazenando os valores num vetor chamado valores, iremos usar o split pra ele salvar em uma posição a cada quebra de linha
            string[] valores = Console.ReadLine().Split(' ');
            Cod1= int.Parse(valores[0]);//Salvando o codigo da peça 1 na posiçao 0 do vetor valores
            qnt1 = int.Parse(valores[1]);
            preco1= double.Parse(valores[2], CultureInfo.InvariantCulture);//Usando o culture info para poder escrever os valores usando , (tb ira exibir)

            //Fazendo o mesmo para as peças 2
            valores = Console.ReadLine().Split(' ');
            Cod2= int.Parse(valores[0]);
            qnt2= int.Parse(valores[1]);
            preco2= double.Parse(valores[2], CultureInfo.InvariantCulture);

            total=preco1*qnt1+preco2*qnt2;
            Console.WriteLine("Preço a pagar: "+total.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 6
            double A2, B2, C2, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores1 = Console.ReadLine().Split(' ');
            A2 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            B2 = double.Parse(valores1[1], CultureInfo.InvariantCulture);
            C2 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
