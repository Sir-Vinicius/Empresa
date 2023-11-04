using System;

class main
{
    static void Main(string[] args)
    {
        Supervisor gerente1 = new Gerente("Maria Vitória (Gerente 1)");
        Supervisor gerente2 = new Gerente("Carlos Alberto (Gerente 2)");
        Funcionario caixa1 = new Caixa("Camila Arantes (Caixa 1)");
        Funcionario caixa2 = new Caixa("Bruno Santos (Caixa 2)");
        Funcionario atendente1 = new Atendente("Mariana Oliveira (Atendente 1)");
        Funcionario atendente2 = new Atendente("Rafael Lima (Atendente 2)");

        gerente1.Adicionar(caixa1);
        gerente1.Adicionar(caixa2);

        gerente2.Adicionar(atendente1);
        gerente2.Adicionar(atendente2);

        gerente1.ListarFuncionarios();
        gerente2.ListarFuncionarios();

    }
}