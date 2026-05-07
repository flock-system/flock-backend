# 🐑 Flock [En]

> A simple platform designed to help churches manage members and care for people.

---

## 📖 About the Project

Flock is a SaaS platform built to help small and medium-sized churches organize their members and care for people more effectively.

Many churches still rely on notebooks or spreadsheets, which often leads to disorganized data and lack of proper follow-up.
Flock aims to simplify this process by providing a clean, modern and easy-to-use system.

---

## 🎯 Goal

Create a simple, useful and scalable product that:

* Replaces manual member management (paper/Excel)
* Helps leaders track and care for people
* Can evolve into a commercial SaaS product
* Serves as a real-world portfolio project

---

## 🚀 Current Scope (MVP)

The first version focuses on:

* Member registration
* Member listing
* Basic validation
* Simple data structure

> ⚠️ The MVP is intentionally small to validate real usage before expanding.

---

## 🧩 Future Features (Roadmap)

* Member status (active, inactive, visitor)
* Interaction history (follow-ups)
* Groups / cells management
* Reports and insights
* Authentication and multi-church support

---

## 🏗️ Architecture

The project follows a **layered architecture inspired by Clean Architecture**, focusing on separation of concerns and scalability.

### 📦 Layers

* **API** → Entry point (Controllers, HTTP)
* **Application** → Business use cases and services
* **Domain** → Core entities and rules
* **Infrastructure** → Database and external integrations

---

### 🔄 Flow

User → API → Application → Domain → Infrastructure → Database

---

## 🛠️ Tech Stack

* Backend: .NET (ASP.NET Core Web API)
* Database: PostgreSQL
* ORM: Entity Framework Core

---

## 📂 Project Structure

```bash
/src
 ├── Flock.Api
 ├── Flock.Application
 ├── Flock.Domain
 ├── Flock.Infrastructure
```

---

## 🔀 Git Workflow

* `main` → Production
* `develop` → Development
* `feature/*` → New features

Pull Requests are required to merge into `main`.

---

## 📋 Project Management

We use GitHub Issues and Projects to manage:

* User Stories (business features)
* Tasks (technical work)
* Sprint-based execution

---

## 🧪 Current Status

🚧 In development — MVP phase

---

## 🤝 Contributing

This project is currently developed by a small team as a learning and product-building initiative.

---

## 📌 Vision

Flock is not just about managing data.

It’s about helping churches care for people better.

---

## 📎 License

MIT (or define later)

---

# 🐑 Flock [pt-br]

> Uma plataforma simples para ajudar igrejas a gerenciar membros e cuidar de pessoas.

---

## 📖 Sobre o Projeto

O Flock é uma plataforma SaaS criada para ajudar igrejas pequenas e médias a organizarem seus membros e cuidarem de pessoas de forma mais eficiente.

Hoje, muitas igrejas ainda utilizam cadernos ou planilhas, o que acaba gerando desorganização e dificuldade no acompanhamento das pessoas.
O Flock surge para simplificar esse processo com um sistema moderno, simples e fácil de usar.

---

## 🎯 Objetivo

Criar um produto simples, útil e escalável que:

* Substitua controles manuais (papel/Excel)
* Ajude líderes a acompanharem pessoas
* Possa evoluir para um SaaS comercial
* Sirva como um projeto real de portfólio

---

## 🚀 Escopo Atual (MVP)

A primeira versão foca em:

* Cadastro de membros
* Listagem de membros
* Validações básicas
* Estrutura simples de dados

> ⚠️ O MVP é propositalmente enxuto para validar o uso real antes de evoluir.

---

## 🧩 Próximas Funcionalidades (Roadmap)

* Status de membros (ativo, inativo, visitante)
* Histórico de acompanhamento
* Gestão de grupos / células
* Relatórios e insights
* Autenticação e suporte a múltiplas igrejas

---

## 🏗️ Arquitetura

O projeto segue uma **arquitetura em camadas inspirada na Clean Architecture**, com foco em separação de responsabilidades e escalabilidade.

### 📦 Camadas

* **API** → Entrada da aplicação (Controllers, HTTP)
* **Application** → Casos de uso e regras de aplicação
* **Domain** → Entidades e regras de negócio
* **Infrastructure** → Banco de dados e integrações externas

---

### 🔄 Fluxo

Usuário → API → Application → Domain → Infrastructure → Banco de Dados

---

## 🛠️ Tecnologias

* Backend: .NET (ASP.NET Core Web API)
* Banco de dados: PostgreSQL
* ORM: Entity Framework Core

---

## 📂 Estrutura do Projeto

```bash id="k6ay9v"
/src
 ├── Flock.Api
 ├── Flock.Application
 ├── Flock.Domain
 ├── Flock.Infrastructure
```

---

## 🔀 Fluxo de Git

* `main` → Produção
* `develop` → Desenvolvimento
* `feature/*` → Novas funcionalidades

Pull Requests são obrigatórios para merge na branch `main`.

---

## 📋 Gerenciamento do Projeto

Utilizamos Issues e Projects do GitHub para organizar:

* User Stories (funcionalidades de negócio)
* Tasks (tarefas técnicas)
* Execução baseada em sprints

---

## 🧪 Status Atual

🚧 Em desenvolvimento — fase de MVP

---

## 🤝 Contribuição

Este projeto está sendo desenvolvido como uma iniciativa de aprendizado e construção de produto real.

---

## 📌 Visão

O Flock não é apenas sobre gerenciar dados.

É sobre ajudar igrejas a cuidarem melhor de pessoas.

---

## 📎 Licença

MIT (ou definir futuramente)
