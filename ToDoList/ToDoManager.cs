namespace TODOLIST
{
    public class ToDoManager
    {
        private readonly List<ToDoTask> _tasks = [];

        public void AddTask(string Desc)
        {
            if (string.IsNullOrWhiteSpace(Desc))
            {
                Console.WriteLine("Task Description cannot be empty");
                return;
            }

            _tasks.Add(new ToDoTask(Desc)); //Add the task: Create a NEW ToDoTask object and add it to the list

            Console.WriteLine("Task added successfully");
        }

        public void ViewTask()
        {
            if (_tasks.Count == 0)
            {
                 Console.WriteLine("\nYour To-Do list is currently empty.");
                 return;
            }

            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"\n {i + 1}.  {_tasks[i]}") ;
            }
        }

        public void CompleteTask(int taskNumber)
{
    // The user sees "1", but the list starts at "0"
    int index = taskNumber - 1; 

    if (index >= 0 && index < _tasks.Count)
    {
        _tasks[index].MarkAsDone();
        Console.WriteLine("Success: Task marked as done!");
    }
    else
    {
        Console.WriteLine("Error: That task number does not exist.");
    }
}


       public void DeleteTask(int taskNumber)
{
    // Adjust for zero-based indexing
    int index = taskNumber - 1;

    // Validation: check if the index is within the list boundaries
    if (index >= 0 && index < _tasks.Count)
    {
        // Store the description briefly just to tell the user what was deleted
        string removedTask = _tasks[index].Description;
        
        _tasks.RemoveAt(index);
        
        Console.WriteLine($"Deleted: {removedTask}");
    }
    else
    {
        Console.WriteLine("Error: Invalid task number. Nothing was deleted.");
    }
}


    }
}