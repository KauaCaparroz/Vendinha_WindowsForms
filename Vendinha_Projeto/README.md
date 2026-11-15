# Projeto Vendinha

Sistema desenvolvido para controlar os clientes e suas dívidas em uma vendinha, substituindo o controle que antes era feito em papel

## Tecnologias utilizadas

- C#
- Windows Forms
- .NET 10
- Entity Framework Core
- SQLite

## Funcionalidades

- Cadastro de clientes.
- Validação de CPF
- Impedimento de CPF duplicado
- Edição e exclusão de clientes
- Cadastro de dívidas
- Consulta de dívidas por cliente
- Pagamento de dívidas
- Pesquisa de clientes pelo nome
- Listagem de clientes ordenada pelo valor das dívidas
- Paginação de 10 clientes por vez
- Cálculo automático da idade dos clientes

## Banco de dados

O projeto utiliza SQLite para armazenar os dados dos clientes e das dívidas

O acesso ao banco é feito utilizando Entity Framework Core

O arquivo `banco.sql` contém os comandos para criação das tabelas Clientes e Dividas

## Como executar o projeto

1. Abrir a solução no Visual Studio
2. Verificar se o .NET 10 está instalado
3. Restaurar os pacotes NuGet, se necessário
4. Executar o projeto pressionando F5
