using System.ComponentModel.DataAnnotations;

namespace MyAbpProject
{
    public class CreateTodoDto
    {
        [Required]
        public string Text { get; set; }
    }
}
