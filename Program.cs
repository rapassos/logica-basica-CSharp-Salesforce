namespace CSharp;

// Definição da Classe
public class Pessoa{
    public string Nome { get; set; }
    public int Idade  { get; set; }

    // Declaração do metodo Saudacao
    public void Saudacao(){
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}


class Program
{
    static void Main(string[] args)
    {
         // Conceitos básicos

        // Tipos de Dados Primitivos

        // Inteiros
        byte b = 100;
        short s = 10000;
        int i = 25;
        long l = 10000000000L;
        sbyte sb = -100;

        // Inteiros sem sinal, ignoram a parte negativa que podem ser armazenada dobrando o
        // valor positivo, ou seja, começam a contar em 0. 
        ushort us = 20000;
        uint ui = 4000000000U;
        ulong ul = 10000000000000000000UL;

        // Tipos de Ponto Flutuante
        float f = 3.14F;
        double d = 3.141592653589793;

        // Tipo Decimal
        decimal dec = 100.25M;

        // Tipo Caractere
        char c = 'A';

        // Tipo Booleano
        bool isTrue = true;

        // Tipos de Dados Não Primitivos (Referenciais)
        string msg =  "Olá, mundo!";

        // Arrays
        int[] numeros = { 1, 2, 3, 4, 5};
        string[] nomes  = new string[3];
        nomes[0] = "Alice";
        nomes[1] = "Bob";
        nomes[2] = "Carol";

        // Classes e Objetos

        Pessoa p = new Pessoa(); // Criação do objeto
        //p.Nome = "Alice";
        p.Nome = nomes[0];
        //p.Idade = 18;
        p.Idade = i;

        p.Saudacao(); //Saída: Olá, meu nome é Alice e tenho 25 anos.

        // Entrada e Saída de Dados

        // Definição da classe no inicio do arquivo

        // Entrada de Dados
        Console.WriteLine("Digite o seu nome:"); //Saida de dados
        string nome = Console.ReadLine(); // Lê a entrada e armazena na variavel nome

        Console.WriteLine("Digite a sua idade:"); //Saida de dados
        int idade = int.Parse(Console.ReadLine());// Lê a entrada, converte para inteiro e armazena na variavel idade

        Console.WriteLine("Olá, "+ nome + "! Você tem "+ idade + " anos."); //Saida de dados
    }
}
