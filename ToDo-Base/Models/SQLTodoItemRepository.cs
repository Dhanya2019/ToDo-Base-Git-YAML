using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoItemMgmt.Models
{
    public class SQLTodoItemRepository : ITodoItemRepository
    {
        private readonly TodoDBContext context;
        private readonly ILogger<SQLTodoItemRepository> logger;

        public SQLTodoItemRepository(TodoDBContext context,
                                     ILogger<SQLTodoItemRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }


        public TodoItem Add(TodoItem TodoItem)
        {
            logger.LogTrace("Inside SQLTodoItemRepository::Add, with TodoItem ID={0}, Name ={1}", TodoItem.Id, TodoItem.Name);

            context.TodoItems.Add(TodoItem);
            context.SaveChanges();
            return TodoItem;
        }

        public TodoItem Delete(long Id)
        {
            logger.LogTrace("Inside SQLTodoItemRepository::Delete, with TodoItemId={0}", Id);
            TodoItem TodoItem = context.TodoItems.Find(Id);
            logger.LogTrace("Inside SQLTodoItemRepository::Delete, with TodoItem ID={0}, Name ={1}", TodoItem.Id, TodoItem.Name);

            if (TodoItem != null)
            {
                context.TodoItems.Remove(TodoItem);
                context.SaveChanges();
            }
            return TodoItem;
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            logger.LogTrace("Inside SQLTodoItemRepository::GetAllTodoItems");

            return context.TodoItems;
        }

        public TodoItem GetTodoItem(long Id)
        {
            logger.LogTrace("Inside SQLTodoItemRepository::GetTodoItem, with TodoItemID={0}", Id);
            return context.TodoItems.Find(Id);
        }

        public TodoItem Update(TodoItem TodoItemChanges)
        {
            logger.LogTrace("Inside SQLTodoItemRepository::Update, with TodoItem ID={0}, Name ={1}", TodoItemChanges.Id, TodoItemChanges.Name);

            var TodoItem = context.TodoItems.Attach(TodoItemChanges);
            TodoItem.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return TodoItemChanges;
        }
    }
}