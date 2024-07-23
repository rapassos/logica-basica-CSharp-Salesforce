using CSharp;

public abstract class AbsPessoa{
    public string? Nome { get; set; }
    public abstract void MostraNome();
}

public abstract class Funcionario : AbsPessoa{
    public override void MostraNome()
    {
        Console.WriteLine($"Meu nome é {Nome}.");
    }
}

public class Gerente : Funcionario{
    public void MostraFuncao(){
        Console.WriteLine($"Minha função é Gerente");
    }
}