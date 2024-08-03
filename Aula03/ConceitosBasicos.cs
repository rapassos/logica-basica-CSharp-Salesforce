namespace CSharp;
public class ConceitosBasicos {

    // Conceitos básicos
    //
    // Variaveis
    // Espaço reservado na memória para armazenamento de informação durante a execução do programa
    // Exemplo - Calcular a idade do usuário:
    // 01 - Criar as variaveis 'ano', 'nascimento' e 'idade';
    // 02 - Solicitar ao usuário o seu ano de nascimento;
    // 03 - Armazenar este valor recebido na variável 'nascimento';
    // 04 - Pegar o ano atual na informações do sistema e armazenar na variável 'ano';
    // 05 - Calcular a idade através da formula ('idade' = 'ano' - 'nascimento');
    // 06 - Exibir a Mensagem "A sua idade é 'idade'.'";
    public void ExVariaveis() {
        int ano,nascimento,idade;
        Console.WriteLine("Exemplo de uso de variáveis \nCalcule a idade pelo ano de nascimento");
        Console.WriteLine("Entre com o ano de nascimento:");
        nascimento = int.Parse(Console.ReadLine());
        ano = DateTime.Now.Year;
        idade = ano - nascimento;
        Console.WriteLine($"A sua idade é {idade}");
    }

    // Constantes
    // Espaço reservado na memória para armazenamento de informação fixa durante a execução do programa
    // Exemplo - Calcular a área e o perimetro de um circulo
    // 01 - Criar as variáveis 'raio', 'area' e 'perimetro';
    // 02 - Criar a constante 'pi' com o valor 3.14159265359;
    // 03 - Solicitar ao usuário o tamanho do raio do circulo;
    // 04 - Armazenar este valor na variável 'raio';
    // 05 - Calcular a área através da formula ('area' = 'pi' * 'raio' ^ 2);
    // 06 - Exibir a mensagem "A área do circulo é 'area'.";
    // 07 - Calcular o perimetro através da formula ('perimetro' = 2 * 'pi' * 'raio');
    // 08 - Exibir a mensagem "O perímetro o circulo é 'perimetro'.";
    public void ExConstantes() {
        Console.WriteLine("Calcule a área e o perimetro  de um circlo a partir do raio");
    }
    public ConceitosBasicos() {
        Console.WriteLine("Conceitos básicos");
        ExVariaveis();
        ExConstantes();
    }

}