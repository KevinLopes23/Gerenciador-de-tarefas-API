﻿namespace Gerenciador_de_tarefas.Models;

public class TaskModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public string Priority { get; set; }

    public DateTime DueDate { get; set; }

    public string Status { get; set; }
}