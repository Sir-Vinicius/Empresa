using System;

public abstract class Funcionario
{
    public string NomeFuncionario { get; set; }

    public virtual void PrintNomeDoFuncionario()
    {
        Console.WriteLine(NomeFuncionario);
    }

    public virtual void ListarFuncionarios()
    {
        Console.WriteLine($"Funcionários supervisionados por {NomeFuncionario}:");
    }
}