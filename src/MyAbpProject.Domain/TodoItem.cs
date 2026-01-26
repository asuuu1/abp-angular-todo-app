using Volo.Abp.Domain.Entities;
using System;

public class TodoItem : Entity<Guid>
{
    public string Text { get; set; }
    public bool IsDone { get; set; }
}
