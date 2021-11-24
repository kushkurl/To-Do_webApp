using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyToDoList.Pages
{
    public class IndexModel : PageModel
    {
        
        [FromForm]
        public Models.ToDos addTask { get; set; }
        
        //public Models.ToDos editTask { get; set; }
        [FromForm]
        public List<Models.ToDos> ToDos { get; set; }
        
        public List<Models.ToDos> ToDoList = new List<Models.ToDos>();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            
            _logger = logger;
            //ToDos = new List<Models.ToDos>();
            ToDoList.Add(new Models.ToDos() { Title = "test1", Description = "This is test 1", DueDate = new DateTime(2021, 12, 30), IsCompleted = false });
            ToDos = ToDoList;
            /*ToDos.Add(new Models.ToDos() { Title = "test2", Description = "This is test 2", DueDate = new DateTime(2021, 12, 2), IsCompleted = true });
            ToDos.Add(new Models.ToDos() { Title = "test3", Description = "This is test 3", DueDate = new DateTime(2021, 12, 10), IsCompleted = false });
            ToDos.Add(new Models.ToDos() { Title = "test4", Description = "This is test 4", DueDate = new DateTime(2021, 11, 30), IsCompleted = true });
            ToDos.Add(new Models.ToDos() { Title = "test5", Description = "This is test 5", DueDate = new DateTime(2021, 11, 28), IsCompleted = false });*/
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                ToDos = ToDoList;
                ToDos.Add(addTask);
                ToDoList = ToDos;
                return null;
            }
            
        }
    }
}
