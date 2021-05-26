using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoItemMgmt.Models
{
    public class MockTodoItemRepository : ITodoItemRepository
    {
        private List<TodoItem> _TodoItemList;

        public MockTodoItemRepository()
        {
            //    _TodoItemList = new List<TodoItem>()   {
            //new TodoItem() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
            //new TodoItem() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
            //new TodoItem() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" },
            //};

            _TodoItemList = new List<TodoItem>()    {
            new TodoItem() { Id = 1, Name = "Pay Rent", IsComplete = false},
            new TodoItem() { Id = 2, Name = "Property Tax", IsComplete = false},
            new TodoItem() { Id = 3, Name = "Broadband Bill", IsComplete = false},
            new TodoItem() { Id = 4, Name = "Milk Bill", IsComplete = false},
        };
        }

        public TodoItem Add(TodoItem TodoItem)
        {
            TodoItem.Id = _TodoItemList.Max(e => e.Id) + 1;
            _TodoItemList.Add(TodoItem);
            return TodoItem;
        }

        public TodoItem Delete(long Id)
        {
            TodoItem TodoItem = _TodoItemList.FirstOrDefault(e => e.Id == Id);
            if (TodoItem != null)
            {
                _TodoItemList.Remove(TodoItem);
            }
            return TodoItem;
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _TodoItemList;
        }

        public TodoItem GetTodoItem(long Id)
        {
            return this._TodoItemList.FirstOrDefault(e => e.Id == Id);
        }

        public TodoItem Update(TodoItem TodoItemChanges)
        {
            TodoItem TodoItem = _TodoItemList.FirstOrDefault(e => e.Id == TodoItemChanges.Id);
            if (TodoItem != null)
            {
                TodoItem.Name = TodoItemChanges.Name;
                TodoItem.IsComplete = TodoItemChanges.IsComplete;
            }
            return TodoItem;
        }
    }
}