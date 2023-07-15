namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list prgram.");

            List<string> taskList = new List<string>();
            string option = "";

            while (option != "exit")
            {
                Console.WriteLine("What would you like to do ?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter exit to exit the program");

                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the list.");
                    string task = Console.ReadLine();  
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the number of the task to remove from the list.");
                    int taskNumber = int.Parse(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                    Console.WriteLine("Task has been removed from the list");
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list");

                    for (int i = 0;i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "exit") 
                {
                    Console.WriteLine("Exiting program.");
                }
                else
                {
                    Console.WriteLine("Invalid Option, please try again");
                }
            }

            Console.WriteLine("Thank you for using the program.");
        }
    }
}