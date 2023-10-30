# Projeto Empresa - Explorando Padrão de Projeto Composite

Projeto da Faculdade com o objetivo de estudar o Design Pattern Composite.

## Hierarquia

Neste projeto, exploramos a aplicação do padrão de projeto Composite em uma estrutura organizacional que representa uma empresa. A hierarquia é composta por diferentes tipos de funcionários, cada um com seu próprio conjunto de responsabilidades.

### Presidente
- O nível mais alto da organização é o **Presidente**, que supervisiona diretamente os **Gerentes**.

### Gerente 1
- **Gerente 1** é responsável por supervisionar os **Caixas 1** e **Caixa 2**.

#### Caixa 1
- **Caixa 1** desempenha funções específicas no departamento de caixa.

#### Caixa 2
- **Caixa 2** também faz parte do departamento de caixa.

### Gerente 2
- **Gerente 2** supervisiona os **Atendentes 1** e **Atendente 2**.

#### Atendente 1
- **Atendente 1** é um membro da equipe de atendimento ao cliente.

#### Atendente 2
- **Atendente 2** também atua no atendimento ao cliente.

Esta hierarquia é representada usando o padrão de projeto Composite, que permite tratar objetos individuais e composições de objetos de maneira uniforme. A estrutura hierárquica torna mais fácil adicionar, remover e listar funcionários de forma flexível.

## Benefícios do Padrão Composite

- Uniformidade: Trate funcionários individuais e grupos da mesma maneira.
- Estruturas Hierárquicas: Crie facilmente estruturas hierárquicas complexas.
- Flexibilidade: Adicione ou remova elementos na hierarquia de forma eficiente.

Este projeto demonstra como o padrão Composite pode ser aplicado a cenários do mundo real, tornando o código mais organizado e fácil de manter.

