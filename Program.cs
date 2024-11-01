// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

enum userChoice
{
    AddTask = 1,
    DeleteTask = 2,
    Exit
}


public class Program
{
    public static void Main(string[] args)
    {
        List<string> toDoList = new List<string>();
        while (true)
        {

            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Delete task");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());


            if (choice == (int)userChoice.AddTask)
            {
                Console.WriteLine("Enter Task : ");
                string task = Console.ReadLine();
                toDoList.Add(task);
                Console.Clear();
                Console.WriteLine("Task Added Succesfully!");

            }
            else if (choice == (int)userChoice.DeleteTask)
            {
                if (toDoList.Count > 0)
                {
                    Console.WriteLine("Enter the no of task you want to delete : ");

                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                    }
                    int taskNum = int.Parse(Console.ReadLine());
                    taskNum--;

                    if (taskNum >= 0 && taskNum <= toDoList.Count)
                    {
                        toDoList.RemoveAt(taskNum);
                        Console.Clear();
                        Console.Write("Task deleted successfully!");
                        Console.WriteLine("");
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("Invalid Task Number!");
                        Console.WriteLine();
                    }
                }
            }
            else if (choice == (int)userChoice.Exit)
            {
                break;
            }

            // --- Display the toDo list ---
            if (toDoList.Count == 0)
            {
                Console.WriteLine("1. Add task");
                Console.WriteLine("1. Exit");
            }
            if (toDoList.Count > 0)
            {
                Console.WriteLine("-- ToDo List --");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine("✅ " + toDoList[i]);
                }
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("-- No Tasks --");
                Console.WriteLine();
            }
        }
    }
}



