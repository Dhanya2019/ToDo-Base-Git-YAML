using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoItemMgmt.Models
{
    public interface ITodoItemRepository
    {
        TodoItem GetTodoItem(long Id);
        IEnumerable<TodoItem> GetAllTodoItems();
        TodoItem Add(TodoItem TodoItem);
        TodoItem Update(TodoItem TodoItemChanges);
        TodoItem Delete(long Id);
    }
}
