using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TodoListProject
{
    public class TodoList
    {
        private readonly List<TodoItem> todoItems = new();

        public ReadOnlyCollection<TodoItem> TodoItems
        {
            get
            {
                return todoItems.AsReadOnly();
            }
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            todoItems.Add(todoItem);
        }

        public void RemoveTodoItem(int index)
        {
            todoItems.RemoveAt(index);
        }

        public IList<TodoItem> GetAllTodoItems()
        {
            return todoItems.AsReadOnly();
        }
    }
}