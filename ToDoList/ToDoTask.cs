using System.Dynamic;

namespace TODOLIST
{
    public class ToDoTask
    {
        private string _description;
        private bool _isCompleted;
        private DateTime _createdAt;

        public string Description => _description;

        public bool IsCompleted => _isCompleted;
        public DateTime CreatedAt => _createdAt;
        public ToDoTask(string desc)
        {
            this._description = desc;
            this._isCompleted = false;
            this._createdAt = DateTime.Now;
        }

        public void MarkAsDone()
        {
            _isCompleted = true ;
            _createdAt = DateTime.Now;
        } 
       
        public override string ToString() => 
    $"[{ (IsCompleted ? "DONE" : "PENDING") }] {Description} (Created: {CreatedAt:MMM dd, HH:mm})";

    }
}
