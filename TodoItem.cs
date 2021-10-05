using System;

namespace TodoListProject
{
    public class TodoItem
    {
        public string label;
        bool isDone;
        public bool IsDone
        {
            get
            {
                return isDone;
            }
            set
            {
                isDone = value;
                if (isDone)
                {
                    completedAt = DateTime.Now;
                }
            }
        }
        private DateTime completedAt;

        private DateTime createdAt;

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
        }

        public TodoItem()
        {
            createdAt = DateTime.Now;
        }

        public void ToggleIsDone()
        {
            isDone = !isDone;
            if (isDone)
            {
                completedAt = DateTime.Now;
            }
        }
    }
}