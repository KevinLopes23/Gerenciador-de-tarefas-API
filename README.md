<div align="center">

# 🗂️ Gerenciador de Tarefas API

**API REST em ASP.NET Core para criar, consultar, editar e excluir tarefas.**

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

</div>

## 💡 Sobre

API para um gerenciador de tarefas simples. Cada tarefa tem nome, descrição, prioridade, data de entrega e status; os dados ficam em uma lista em memória (reiniciar a aplicação apaga tudo). Projeto de estudo de C#/.NET.

## ✨ Funcionalidades

- Criar tarefa
- Listar todas as tarefas
- Buscar tarefa pelo ID
- Editar tarefa
- Excluir tarefa
- Documentação via Swagger (ambiente de desenvolvimento)

Exemplo de tarefa:

```json
{
  "name": "Nome da tarefa",
  "description": "Descrição da tarefa",
  "priority": "alta",
  "dueDate": "2024-12-31T23:59:59",
  "status": "em andamento"
}
```

## 🛠️ Tecnologias

- C# / ASP.NET Core Web API (.NET 8)
- Swashbuckle (Swagger)

## 📌 Endpoints

O controller se chama `TaksController`, por isso a rota base é `/api/Taks`.

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/api/Taks` | Cria uma tarefa |
| `GET` | `/api/Taks` | Lista as tarefas |
| `GET` | `/api/Taks/{id}` | Busca uma tarefa pelo ID |
| `PUT` | `/api/Taks/{id}` | Atualiza uma tarefa |
| `DELETE` | `/api/Taks/{id}` | Remove uma tarefa |

## 🚀 Como rodar

Requer .NET 8 SDK.

```bash
git clone https://github.com/KevinLopes23/Gerenciador-de-tarefas-API.git
cd "Gerenciador-de-tarefas-API/Gerenciador de tarefas"
dotnet run
```

O Swagger fica em `http://localhost:5073/swagger`.

## 📄 Licença

Distribuído sob a licença MIT. Veja [LICENSE](LICENSE).

## 👤 Autor

Feito por [Kevin Lopes](https://github.com/KevinLopes23)
