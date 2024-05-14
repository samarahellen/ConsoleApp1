using System;

public class Banco
{
	//Atributos
	private int _idconta;
	private string _nome;
	private int _saldo;

	//Método construtor
	public Banco(int IdConta, string Nome, int Saldo)
	{
		_idconta = IdConta;
		_nome = Nome;
		_saldo = Saldo;
	}
	public Banco() {
		_idconta = 0;
		_nome = null;
		_saldo = 0;
	}
	//Get e Set
	public string Nome
	{
		get { return _nome; }
		set { _nome = value; }
	}

	public int IdConta
	{
		get { return _idconta; }
	}
    public void SetIdConta(int novoId)
    {
        // Verifique se o ID já foi definido
        if (_idconta != 0)
        {
            Console.WriteLine("O ID da conta não pode ser alterado após a criação.");
            return;
        }

        _idconta = novoId;
    }

    public int Saldo
	{
		get { return _saldo; }
		set { _saldo = value; }
	}

    //Metodos de Saque e Deposito

    //ToString
    public override string ToString()
    {
        return $"Conta #{_idconta}: Nome: {_nome}, Saldo: {_saldo}";
    }


}
