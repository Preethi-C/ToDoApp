using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DisplayName("Is Done")]
        public bool IsDone {  get; set; }
    }
}
