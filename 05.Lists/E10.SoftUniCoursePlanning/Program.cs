using System;
using System.Collections.Generic;
using System.Linq;

/*
Data Types, Objects, Lists
Add:Databases
Insert:Arrays: 0
Remove: Lists 
course start

Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
*/
namespace E10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        string titleOne = command[1];
                        schedule = AddLesson(schedule, titleOne);
                        break;
                    case "Insert":
                        titleOne = command[1];
                        int index = int.Parse(command[2]);
                        schedule = InsertLesson(schedule, titleOne, index);
                        break;
                    case "Remove":
                        titleOne = command[1];
                        schedule = RemoveLesson(schedule, titleOne);
                        break;
                    case "Swap":
                        titleOne = command[1];
                        string titleTwo = command[2];
                        schedule = SwapLesson(schedule, titleOne, titleTwo);
                        break;
                    case "Exercise":
                        titleOne = command[1];
                        schedule = ExerciseLesson(schedule, titleOne);
                        break;

                    default:
                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static List<string> ExerciseLesson(List<string> schedule, string title)
        {
            string exercise = $"{title}-Exercise";
            if (schedule.Contains(title) && !schedule.Contains($"{title}-Exercise"))
            {
                int lessonIndex = schedule.IndexOf(title);
                schedule.Insert(lessonIndex + 1, exercise);
            }
            else if (!schedule.Contains(title))
            {
                schedule.Add(title);
                schedule.Add(exercise);
            }
            return schedule;
        }

        static List<string> SwapLesson(List<string> schedule, string titleOne, string titleTwo)
        {
            if (schedule.Contains(titleOne) && schedule.Contains(titleTwo))
            {
                int indexTitleOne = schedule.IndexOf(titleOne);
                int indexTitleTwo = schedule.IndexOf(titleTwo);

                string tempTitle = titleOne;              //title switch happens here
                schedule[indexTitleOne] = titleTwo;
                schedule[indexTitleTwo] = tempTitle;

               schedule = SwapExercise(schedule, titleOne, indexTitleTwo);  //exchange exercise for first title relative to second title index
               schedule = SwapExercise(schedule, titleTwo, indexTitleOne);  

            }
            return schedule;
        }

        static List<string> SwapExercise(List<string> schedule, string titleOne, int swapIndex)
        {
            string tempTitle = $"{titleOne}-Exercise";  //set the new string to correct input
            int indexTitleOne = schedule.IndexOf(tempTitle);  //returns negative if exercise does not exist
            if (indexTitleOne >= 0)
            {
                RemoveLesson(schedule, tempTitle); // remove exercise from old position
                InsertLesson(schedule, tempTitle, swapIndex + 1); //add exercise to new position
            }
            return schedule;
        }

        static List<string> RemoveLesson(List<string> schedule, string title)
        {
            if (schedule.Contains(title))
            {
                schedule.Remove(title);
            }
            return schedule;
        }

        static List<string> InsertLesson(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))
            {
                schedule.Insert(index, title);
            }
            return schedule;
        }

        static List<string> AddLesson(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                schedule.Add(title);
            }
            return schedule;
        }
    }
}