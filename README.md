<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gerenciador de Tarefas</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 20px;
            background-color: #f4f4f4;
        }
        h1, h2, h3 {
            color: #333;
        }
        code {
            background-color: #eaeaea;
            padding: 2px 4px;
            border-radius: 4px;
        }
        pre {
            background-color: #eaeaea;
            padding: 10px;
            border-radius: 4px;
            overflow-x: auto;
        }
        a {
            color: #007bff;
            text-decoration: none;
        }
        a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>

    <h1>Gerenciador de Tarefas</h1>
    <p>Este é um projeto de API para um sistema de Gerenciador de Tarefas desenvolvido em C# utilizando ASP.NET Core.</p>

    <h2>Funcionalidades</h2>
    <ul>
        <li>Criar uma tarefa</li>
        <li>Visualizar todas as tarefas</li>
        <li>Visualizar uma tarefa específica pelo ID</li>
        <li>Editar informações de uma tarefa</li>
        <li>Excluir uma tarefa</li>
    </ul>

    <h2>Modelo de Tarefa</h2>
    <pre><code>
    {
        "id": 1,
        "name": "Nome da Tarefa",
        "description": "Descrição da tarefa",
        "priority": "alta", // alta, média, baixa
        "dueDate": "2023-12-31T23:59:59",
        "status": "em andamento" // concluída, em andamento, aguardando
    }
    </code></pre>

    <h2>Endpoints</h2>
    <h3>1. Criar uma tarefa</h3>
    <p><strong>POST</strong> /api/tasks</p>
    <p>Corpo da requisição:</p>
    <pre><code>
    {
        "name": "Nome da Tarefa",
        "description": "Descrição da tarefa",
        "priority": "alta",
        "dueDate": "2023-12-31T23:59:59",
        "status": "aguardando"
    }
    </code></pre>

    <h3>2. Visualizar todas as tarefas</h3>
    <p><strong>GET</strong> /api/tasks</p>

    <h3>3. Visualizar uma tarefa específica</h3>
    <p><strong>GET</strong> /api/tasks/{id}</p>

    <h3>4. Editar uma tarefa</h3>
    <p><strong>PUT</strong> /api/tasks/{id}</p>
    <p>Corpo da requisição:</p>
    <pre><code>
    {
        "name": "Nome Atualizado",
        "description": "Descrição Atualizada",
        "priority": "média",
        "dueDate": "2023-12-31T23:59:59",
        "status": "concluída"
    }
    </code></pre>

    <h3>5. Excluir uma tarefa</h3>
    <p><strong>DELETE</strong> /api/tasks/{id}</p>

    <h2>Como Executar o Projeto</h2>
    <ol>
        <li>Clone o repositório: <code>git clone <URL_DO_REPOSITORIO></code></li>
        <li>Entre na pasta do projeto: <code>cd GerenciadorTarefas</code></li>
        <li>Execute o projeto: <code>dotnet run</code></li>
        <li>Acesse a API em <a href="http://localhost:5000">http://localhost:5000</a></li>
    </ol>

    <h2>Considerações Finais</h2>
    <p>Este projeto é uma demonstração de como criar uma API RESTful simples utilizando ASP.NET Core. Sinta-se à vontade para contribuir e melhorar o projeto
