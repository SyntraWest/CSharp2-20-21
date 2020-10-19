using System;
using System.Collections.Generic;
using System.Text;

namespace TodoLijstLibrary
{
    public class TodoLijst
    {
        public List<TodoItem> Items { get; set; }

        public string Naam { get; set; }

        public string Eigenaar { get; set; }
    }
}
