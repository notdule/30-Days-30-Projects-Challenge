using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program.");
            List<string> taskList = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program!");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the list.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list succesfully!");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the number of task to remove.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list :");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting Program");
                }
                else
                {
                    Console.WriteLine("Invalid option selected, please try again.");
                }
            }

            Console.WriteLine("Thank you for using the program!");
        }
    }
}
