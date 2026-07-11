# Marketplace API

API REST desenvolvida em **.NET 8** como projeto de estudo prático durante a disciplina de **Desenvolvimento de APIs** da graduação na **FIAP**.

O objetivo deste projeto é aplicar conceitos fundamentais do desenvolvimento backend utilizando o ecossistema .NET, construindo uma API organizada, escalável e seguindo boas práticas de arquitetura.

O projeto simula uma API responsável pelo gerenciamento de produtos de um marketplace, permitindo operações de cadastro, consulta e exclusão de produtos.

---

## 🎯 Objetivos do projeto

Este projeto tem como objetivo praticar e consolidar conhecimentos em:

* Desenvolvimento de APIs REST com ASP.NET Core;
* Organização de projetos em camadas;
* Injeção de Dependência (Dependency Injection);
* Entity Framework Core;
* Migrations e persistência de dados;
* Integração com SQL Server;
* Repository Pattern;
* Documentação de APIs com Swagger;
* Boas práticas de desenvolvimento backend.

---

# 🛠️ Tecnologias utilizadas

* **.NET 8**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **SQL Server / LocalDB**
* **Swagger / OpenAPI**
* **C#**

---

# 🏗️ Arquitetura do projeto

O projeto foi organizado seguindo uma separação de responsabilidades, buscando aproximar a estrutura utilizada em aplicações reais.

```
Marketplace.API
│
├── Controllers
│   └── Responsável pelos endpoints HTTP da API
│
├── Data
│   └── Configuração do acesso ao banco de dados
│
├── Models
│   └── Entidades do domínio
│
├── Interfaces
│   └── Contratos utilizados pela aplicação
│
├── Repositories
│   └── Camada responsável pela comunicação com o banco
│
├── Services
│   └── Regras de negócio da aplicação
│
└── Migrations
    └── Controle da evolução do banco de dados
```

---

# 📦 Funcionalidades

Atualmente a API contempla:

## Produtos

* Cadastro de produtos;
* Consulta de produtos cadastrados;
* Exclusão de produtos.

---

# 🗄️ Persistência de dados

A aplicação utiliza **Entity Framework Core** para realizar o mapeamento entre as entidades C# e o banco de dados SQL Server.

O banco é gerenciado através de migrations:

Criar uma nova migration:

```bash
Add-Migration NomeDaMigration
```

Atualizar o banco:

```bash
Update-Database
```

---

# 🔌 Endpoints planejados

| Método | Endpoint       | Descrição                 |
| ------ | -------------- | ------------------------- |
| GET    | /products      | Retorna todos os produtos |
| POST   | /products      | Cadastra um novo produto  |
| DELETE | /products/{id} | Remove um produto         |

---

# 🔐 Próximas evoluções

Durante a evolução do projeto serão implementados novos conceitos estudados em aula:

* Autenticação utilizando JWT;
* Autorização baseada em níveis de acesso;
* Middleware para tratamento de erros e logs;
* Cache;
* Testes unitários;
* Melhorias na arquitetura utilizando Services;
* Validações de dados;
* Melhorias na documentação da API.

---

# 🚀 Como executar o projeto

## Pré-requisitos

Antes de executar, tenha instalado:

* .NET 8 SDK;
* SQL Server ou SQL Server LocalDB;
* Visual Studio 2022 ou VS Code.

---

## Configuração do banco

No arquivo:

```
appsettings.json
```

configure a sua connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=MarketplaceDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
```

Execute as migrations:

```bash
Update-Database
```

---

## Executando a aplicação

Execute:

```bash
dotnet run
```

ou utilize o botão de execução da IDE.

A documentação dos endpoints estará disponível através do Swagger:

```
/swagger
```

---

# 📚 Contexto acadêmico

Este projeto foi desenvolvido como parte dos estudos da graduação na **FIAP**, com foco na aplicação prática dos conceitos apresentados na disciplina de desenvolvimento de APIs.

O projeto tem finalidade exclusivamente educacional e está sendo evoluído continuamente como forma de aprendizado e construção de portfólio profissional.

---

# 👨‍💻 Autor

**Gustavo Silva Tiano**

Analista de Sistemas em formação contínua, com foco em desenvolvimento backend utilizando o ecossistema .NET.

Tecnologias de interesse:

* C#
* .NET
* SQL Server
* APIs REST
* Arquitetura de software
* Desenvolvimento de sistemas
