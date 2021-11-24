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
        public Models.ToDos addTask = new Models.ToDos();

        public List<Models.ToDos> ToDos;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ToDos = new List<Models.ToDos>();
            ToDos.Add(new Models.ToDos() { Title = "test1", IsCompleted = false });
            ToDos.Add(new Models.ToDos() { Title = "test2", IsCompleted = true });
            ToDos.Add(new Models.ToDos() { Title = "test3", IsCompleted = false });
            ToDos.Add(new Models.ToDos() { Title = "test4", IsCompleted = true });
            ToDos.Add(new Models.ToDos() { Title = "test5", IsCompleted = false });
        }

        public void OnGet()
        {

        }
    }
}
