using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyToDoList.Models
{
    public class ToDos
    {
        [Required]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        
        public DateTime CompletedOn { get; set; }

        [Required]
        [Display(Name ="Due Date")]
        public DateTime DueDate { get; set; }

        public string Description { get; set; }
    }
}
