using System;

namespace TodoApi.Models
{
    public class TodoItem
    {

        public int id { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public bool done { get; set; }
        public DateTime? dueDate { get; set; }
        public override string ToString()
        {
            return $"{id} {title} {desc} {done} {dueDate}";
        }

    }
}