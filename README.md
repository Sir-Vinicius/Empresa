# Projeto Empresa - Explorando Padrão de Projeto Composite

Este é um projeto acadêmico que tem como objetivo estudar o Design Pattern Composite, aplicado em uma estrutura organizacional que representa uma empresa. A hierarquia é composta por diferentes tipos de funcionários, cada um com seu próprio conjunto de responsabilidades.

## Hierarquia

Neste projeto, exploramos a aplicação do padrão de projeto Composite em uma estrutura organizacional que representa uma empresa. A hierarquia é composta por diferentes tipos de funcionários, cada um com seu próprio conjunto de responsabilidades.

- **Component** (Funcionário) - é uma classe abstrata ou interface que declara os métodos comuns que serão utilizados pelo cliente para acessar os objetos de uma maneira uniforme.
- **Leaf** (Atendente e Caixa) - dentro da estrutura em árvore que é criada por este padrão, esta classe representa uma “folha”, ou seja, um objeto individual que não possui filhos dentro da hierarquia.
- **Composite** (Supervisor) - é o objeto que agrupa os demais objetos que realizam a classe / interface, e que propaga a execução das suas operações para as respectivas operações dos seus filhos. Antes e após essa propagação de métodos, é permitido que sejam efetuados outros processamentos adicionais.

## Presidente

O nível mais alto da organização é o **Presidente**, que supervisiona diretamente os **Gerentes**.

### Gerente 1

Gerente 1 é responsável por supervisionar os **Caixas 1** e **Caixa 2**.

#### Caixa 1

Caixa 1 desempenha funções específicas no departamento de caixa.

#### Caixa 2

Caixa 2 também faz parte do departamento de caixa.

### Gerente 2

Gerente 2 supervisiona os **Atendentes 1** e **Atendente 2**.

#### Atendente 1

Atendente 1 é um membro da equipe de atendimento ao cliente.

#### Atendente 2

Atendente 2 também atua no atendimento ao cliente.

## Benefícios do Padrão Composite

- **Uniformidade:** Trate funcionários individuais e grupos da mesma maneira.
- **Estruturas Hierárquicas:** Crie facilmente estruturas hierárquicas complexas.
- **Flexibilidade:** Adicione ou remova elementos na hierarquia de forma eficiente.

Este projeto demonstra como o padrão Composite pode ser aplicado a cenários do mundo real, tornando o código mais organizado e fácil de manter.
