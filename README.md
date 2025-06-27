# Escola Rustcean

<p align="center">
  <img src="https://github.com/HD-29139/rustacean-school/blob/main/assets/school.gif" width="720">
</p>

Uma aplicação web simples para gerenciamento escolar, criada no padrão **MVC (Model-View-Controller)** usando **ASP.NET Core**, **Entity Framework (Code First)**, e layout responsivo com **Bootstrap**.

---

## 🎓 Funcionalidades

- Cadastro de Alunos
- Cadastro de Disciplinas
- Matrícula de Alunos em Disciplinas
- Atribuição de Notas às Matrículas
- CRUD completo para cada entidade
- Visual moderno e responsivo com Bootstrap

---

## 🛠 Tecnologias Utilizadas

- ASP.NET Core MVC (.NET 8.0)
- Entity Framework Core (Code First)
- SQL Server LocalDB
- Razor Pages (Views)
- Bootstrap

---

## 🔗 Estrutura das Entidades

```plaintext
Um Aluno pode ter muitas Matrículas

Uma Disciplina pode ser cursada por vários Alunos (via Matrículas)

Cada Matrícula é uma relação de um aluno e uma disciplina

A Nota é atribuída a uma matrícula específica
```
---

## Como rodar o projeto

1. **Clone o repositório**  

```nushell
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```
2. **Crie o banco de dados "school" e Execute o script**

```cmd
mysql -u root -p school < script.sql
```

3. **Restaure as dependências**

```nushell
dotnet restore
```
4. **Atualize o banco de dados**

```nushell
dotnet ef database update
```

5. **Execute**

```nushell
dotnet run
```
---
<p align="center">
  <img src="https://github.com/HD-29139/rustacean-school/blob/main/assets/RUST.gif" width="320">
</p>

```rust
“Rustcean” é uma homenagem aos desenvolvedores Rust, mesmo usando C# nesse projeto.
```
