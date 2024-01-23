int i = -1;
List<string> contacts = new List<string>();
while (true)
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Add contact");
    Console.WriteLine("2. View contacts");
    Console.WriteLine("3. Delete contact");
    Console.WriteLine("4. Exit");
    i++;

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You chose to add a contact.");
            Console.WriteLine("Write name of contact: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write number of contact: ");
            string number = Console.ReadLine();
            string contact = ($"{i}. Name: {name} Number: {number}");
            contacts.Add(contact);
            Console.WriteLine("Successfully added.");
            break;
        case "2":
            Console.WriteLine("You chose to view contacts.");
            foreach (var result in contacts)
                Console.WriteLine(result);
            break;
        case "3":
            Console.WriteLine("You chose to delete a contact.");
            Console.WriteLine("Write a number to delete contact.");
            try
            {
                int delete = int.Parse(Console.ReadLine());
                contacts.RemoveAt(delete);
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