namespace CSharp;

public class TiposDeDados{

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
        public TiposDeDados(){
                nomes[0] = "Alice";
                nomes[1] = "Bob";
                nomes[2] = "Carol";

                Console.WriteLine($"Dados primitivos \nInteiros \n byte = {b} \n short = {s}\n int = {i}\n long = {l}\n sbyte = {sb}");
        }
}