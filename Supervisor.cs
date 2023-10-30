using System;
using System.Collections.Generic;

public abstract class Supervisor : Funcionario
{
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void Adicionar(Funcionario novoFuncionario)
    {
        funcionarios.Add(novoFuncionario);
    }

    public void Remover(Funcionario funcionarioAExcluir)
    {
        funcionarios.Remove(funcionarioAExcluir);
    }

    public override void ListarFuncionarios()
    {
        Console.WriteLine($"Funcionários supervisionados por {NomeFuncionario}:");
        foreach (var funcionario in funcionarios)
        {
            funcionario.PrintNomeDoFuncionario();
        }
    }
}