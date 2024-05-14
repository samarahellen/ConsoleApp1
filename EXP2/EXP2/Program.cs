using System.Linq.Expressions;
using System.Net.Http.Headers;
using ExP2; // Adicione esta linha
namespace ExP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, id, saldo, i, op2, saldoAtual, deposito;
            String nome;
            Banco cliente;
            cliente = new Banco();
            do {   
            Console.WriteLine("Bem-vindo ao sistema do banco GALO");
            Console.WriteLine("Digite a operação desejada: ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Exibir dados");
            Console.WriteLine("3 - Alterar cadastro");
            Console.WriteLine("4 - Deposito");
            Console.WriteLine("5 - Saque");
            op = int.Parse(Console.ReadLine());
            

            switch (op){
                case 1:
                    Console.WriteLine("Digite o ID da conta (não poderá ser alterado): ");
                    id = int.Parse(Console.ReadLine());
                    cliente.SetIdConta(id);
                    Console.WriteLine("Digite o nome: ");
                    cliente.Nome= Console.ReadLine();
                    Console.WriteLine("Deseja declarar um saldo inicial? 1-SIM ou 0-NAO: ");
                    i= int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        cliente.Saldo = 0;
                    }
                    else
                    {
                        Console.WriteLine("Digite o saldo inicial: ");
                        cliente.Saldo=int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Cadastro realizado com sucesso!");
                    break;
                case 2:
                    Console.WriteLine(cliente.ToString());
                    break;
                case 3:
                        Console.WriteLine(cliente.ToString());
                        Console.WriteLine("Digite qual dado deseja alterar!");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - ID");
                        op2= int.Parse(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                Console.WriteLine("Digite o nome: ");
                                cliente.Nome = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("ERRO");
                                break;
                           
                        }
                        Console.WriteLine("Cadastro alterado com sucesso!");
                        break;
                case 4:
                        Console.WriteLine("Digite o valor do depósito: ");
                        deposito = int.Parse(Console.ReadLine());
                        cliente.Saldo += deposito;
                        Console.WriteLine("Depósito realizado com sucesso! Saldo atual: R${0}", cliente.Saldo);
                        break;
                case 5:
                        Console.WriteLine("Digite o valor do saque: ");
                        int valorSaque = int.Parse(Console.ReadLine());
                        int taxaSaque = 5;
                        if (valorSaque + taxaSaque <= cliente.Saldo)
                        {
                            cliente.Saldo -= valorSaque + taxaSaque;
                            Console.WriteLine("Saque realizado com sucesso! Saldo atual: R${0}", cliente.Saldo);
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para realizar o saque. Saldo atual: R${0}", cliente.Saldo);
                        }
                        break;


            }
            } while (op != 0);

        }
    }
}
