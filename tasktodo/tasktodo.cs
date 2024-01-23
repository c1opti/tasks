int i = -1;
List<string> tasks = new List<string>();
while (true)
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("4. Exit");
    i++;

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You chose to add a task.");
            Console.WriteLine("Write name of task: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write 1 or completed and 2 or not completed accordingly.");
            string choice2 = Console.ReadLine();
            string task;
            switch (choice2)
            {
                case "1":
                case "completed":
                    task = $"{i}. Task: {name} Ready: completed.";
                    tasks.Add(task);
                    break;
                case "2":
                case "not completed":
                    task = $"{i}. Task: {name} Ready: not completed.";
                    tasks.Add(task);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 2.");
                    break;

            }
            Console.WriteLine("Successfully added.");
            break;
        case "2":
            Console.WriteLine("You chose to view tasks.");
            foreach (var result in tasks)
                Console.WriteLine(result);
            break;
        case "3":
            Console.WriteLine("You chose to delete a task.");
            Console.WriteLine("Write a number to delete task.");
            try
            {
                int delete = int.Parse(Console.ReadLine());
                tasks.RemoveAt(delete);
                Console.WriteLine("Successfully deleted.");
            }
            catch (FormatException error)
            {
                Console.WriteLine("Invalid input. Please enter a number. Error: " + error.Message);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Invalid index. Please try again. Error: " + error.Message);
            }
            break;
        case "4":
            Console.WriteLine("Exiting the program...");
            return;
        default:
            Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
            break;
    }
}