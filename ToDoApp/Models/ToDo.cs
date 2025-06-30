using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public bool IsCompleted {  get; set; }
    }
}
