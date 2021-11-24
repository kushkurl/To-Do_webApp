﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoList.Models
{
    public class ToDos
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedOn { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}