namespace CSharp;

// Exemplo de Declaração de uma Classe
public class Pessoa{
    public string? Nome { get; set; }
    public int Idade  { get; set; }

    // Declaração do metodo Saudacao
    public void Saudacao(){
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}


class Program
{
    static void Main()
    {
        TiposDeDados tpDados = new TiposDeDados();
        //tpDados.tiposDeDados();
        // Classes e Objetos

        // Exemplo de Declaração de uma Classe no inicio deste arquivo

        Pessoa p = new Pessoa(); // Criação do objeto
        p.Nome = "Alice";
        //p.Nome = nomes[0];
        p.Idade = 18;
        //p.Idade = i;

        p.Saudacao(); //Saída: Olá, meu nome é Alice e tenho 25 anos.

        // Entrada e Saída de Dados

        // Entrada de Dados
        Console.WriteLine("Digite o seu nome:"); //Saida de dados
        string nome;
        nome = Console.ReadLine(); // Lê a entrada e armazena na variavel nome

        Console.WriteLine("Digite a sua idade:"); //Saida de dados
        int idade;
        idade = int.Parse(Console.ReadLine());// Lê a entrada, converte para inteiro e armazena na variavel idade

        Console.WriteLine("Olá, "+ nome + "! Você tem "+ idade + " anos."); //Saida de dados


        //Exemplo de classe Abstract Extends Abstract
        Gerente g = new()
        {
            Nome = "João"
        };
        g.MostraNome();
        g.MostraFuncao();



    }
}
