using System;
using System.Collections.Generic;
using TodoListProject;

namespace ExtraLektionEtt
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "a")
                {
                    AddTodoItems(todoList);
                }
                else if (input == "t")
                {
                    ToggleTodoItems(todoList);
                }
                else if (input == "l")
                {
                    ListTodoItems(todoList);
                }
                else if (input == "r")
                {
                    todoList.RemoveTodoItem(1);
                }
                else if (input == "q")
                {
                    Environment.Exit(0);
                }
            }
        }

        private static void ListTodoItems(TodoList todoList)
        {
            foreach (TodoItem item in todoList.GetAllTodoItems())
            {
                int index = todoList.GetAllTodoItems().IndexOf(item);
                Console.WriteLine($"{index}. {item.IsDone} - {item.label}");
            }
        }

        private static void ToggleTodoItems(TodoList todoList)
        {
            foreach (TodoItem item in todoList.GetAllTodoItems())
            {
                item.ToggleIsDone();
            }
        }

        private static void AddTodoItems(TodoList todoList)
        {
            TodoItem todoItem = new();
            todoItem.label = "Unnamed";

            todoList.AddTodoItem(todoItem);
        }
    }
}
