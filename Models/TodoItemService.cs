using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using System;
using System.Linq;


namespace TodoApi.Models
{
    public class TodoItemService : IService
    {
        public TodoItemContext _context;
        protected TodoItemService(TodoItemContext _context)
        {
            this._context = _context;
        }
        public void CreateTodoItem(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }
        public void UpdateTodoItem(TodoItem item, int id)
        {
            item.id = id;
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
        public void DeleteTodoItem(int id)
        {
            TodoItem item = _context.TodoItems.Find(id);
            _context.Remove(item);
            _context.SaveChanges();
        }
        public List<TodoItem> ReadTodoItems()
        {
            return _context.TodoItems.ToList();
        }
    }
}
