using System.ComponentModel;

namespace TODOLIST
{
    public class Program
    {


        static void Main(string[] args)
        {
            ToDoManager taskManager = new ToDoManager();
            bool isRunning = true;


            while (isRunning)

            {
                Menu();
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Invalid input. Please enter a number from the menu.");
                    continue;
                }
                switch (input)
                {
                    case 1:
                        //Add a task
                        AddNewTask(taskManager);
                        break;

                    case 2:
                        Console.WriteLine("View task(s)");
                        taskManager.ViewTask();
                        break;
                    case 3:
                        CompleteExistingTask(taskManager);
                        break;
                    case 4:

                        DeleteExistingTask(taskManager);
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Exiting....Good bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please enter a number");
                        break;
                }

            }
        }

        static void Menu()
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task ");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Enter selection:");
        }

        static void AddNewTask(ToDoManager taskManager)
        {
            Console.WriteLine("\nAdd Task");
            string? desc = "";

            // Loop so it keeps asking if empty
            while (string.IsNullOrWhiteSpace(desc))
            {
                Console.Write("Enter Description: ");
                desc = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(desc))
                {
                    Console.WriteLine("Description cannot be empty. Try again.");
                }
            }

            taskManager.AddTask(desc);
            Console.WriteLine("Task added!");
        }


        static void CompleteExistingTask(ToDoManager taskManager)
        {
            Console.WriteLine("\n--- Complete a Task ---");
            taskManager.ViewTask(); // Show list so they see the numbers

            Console.Write("Enter Task Number: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                taskManager.CompleteTask(taskNumber);
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }

        static void DeleteExistingTask(ToDoManager taskManager)
        {
            Console.WriteLine("\n--- Delete a Task ---");
            taskManager.ViewTask(); // Show list so they see the numbers

            Console.Write("Enter Task Number: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                taskManager.DeleteTask(taskNumber);
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }

    }
}
