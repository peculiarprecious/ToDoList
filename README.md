 # To-Do List Manager (C# Console App)

 # Author
 Precious Nwajei

 # Descrption
A clean, object-oriented console application for managing daily tasks. This project demonstrates core C# programming principles, including Encapsulation, List management, and Input Validation. 

# Features
1. Create: Add new tasks with descriptions.
2. Read: View your current list with status indicators ([PENDING] or [DONE]).
3. Update: Mark specific tasks as completed and update datetime.
4. Delete: Remove tasks from the list by their display number.
5. Robust Validation: Prevents empty tasks and handles invalid menu or index inputs without crashing. 

# Technical Concepts Used
1. Encapsulation: Used private fields (_description, _isCompleted, _createdAt) and public properties to protect data integrity.
2. Expression-Bodied Members: Utilized the => syntax for clean, readable properties and methods.
3. Static Methods: Organized code by moving UI logic (Add/Complete/Delete) into static methods in Program.cs.
4. List Indexing: Implemented logic to map human-readable numbers (1, 2, 3) to zero-based C# indices (0, 1, 2). 

# Project Structure
1. ToDoTask.cs: The Model class representing a single task.
2. ToDoManager.cs: The Logic class handling the CRUD operations on the list.
3. Program.cs: The Interface handling user input and the main application loop.

# How to Run
1. Clone the repository: git clone https://github.com/peculiarprecious/ToDoList
2. Navigate to the directory: cd TODOLIST
3. Run the application: dotnet run

 
# Example Usage

=== Task Manager ===
1. Add Task 
2. View Tasks
3. Complete Task
4. Delete Task
5. Exit

* Selection: 1

Enter Description: Buy groceries

*Task added!