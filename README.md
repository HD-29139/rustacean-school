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




“Rustcean” é uma homenagem aos desenvolvedores Rust, mesmo usando C# para nesse projeto.
