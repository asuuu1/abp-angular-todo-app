using System;

namespace MyAbpProject
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }
    }
}
