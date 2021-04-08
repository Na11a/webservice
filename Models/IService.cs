using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using System;
using System.Linq;
namespace TodoApi.Models
{
    interface IService
    {
        void CreateTodoItem(TodoItem todoItem);
        void DeleteTodoItem(int id);
        List<TodoItem> ReadTodoItems();
        void UpdateTodoItem(TodoItem todoItem, int id);
    }
}

//     class Service : IService
//     {

//         public void CreateTodoItem(TodoItem todoItem)
//         {
//             using (var db = new TodoItemContext())
//             {
//                 Console.WriteLine("create TodoItem");
//                 db.Add(new TodoItem()
//                 {
//                     title = todoItem.title,
//                     desc = todoItem.desc ?? "",
//                     done = todoItem.done ? true : false,
//                     dueDate = todoItem.dueDate
//                 });
//                 db.SaveChanges();
//             }

//         }
//         public void UpdateTodoItem(TodoItem todoItem, int id)
//         {
//             using (var db = new TodoItemContext())
//             {
//                 TodoItem upTodoItem = db.TodoItems.FirstOrDefault(t => t.id == id);
//                 if (upTodoItem != null)
//                 {
//                     upTodoItem.title = todoItem.title;
//                     upTodoItem.desc = todoItem.desc ?? "";
//                     upTodoItem.done = todoItem.done ? true : false;
//                     upTodoItem.dueDate = todoItem.dueDate;
//                 }
//                 db.TodoItems.Update(upTodoItem);
//                 db.SaveChanges();
//                 Console.WriteLine("Update TodoItem");

//             }
//         }

//         public List<TodoItem> ReadTodoItems()
//         {
//             List<TodoItem> TodoItems = new List<TodoItem>();
//             using (var db = new TodoItemContext())
//             {
//                 TodoItems = db.TodoItems.ToList();
//             }
//             return TodoItems;
//         }
//         public void DeleteTodoItem(int id)
//         {
//             using (var db = new TodoItemContext())
//             {
//                 TodoItem delTodoItem = db.TodoItems.FirstOrDefault(TodoItem => TodoItem.id == id);
//                 if (delTodoItem != null)
//                 {
//                     db.TodoItems.Remove(delTodoItem);
//                     db.SaveChanges();
//                 }
//             }
//         }
//     }
// }