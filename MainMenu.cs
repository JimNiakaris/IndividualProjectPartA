using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class MainMenu
    {


        public static void MainMenuMethod()
        {
            List<Course> Courses = new List<Course>();
            List<Assignment> Assignments = new List<Assignment>();
            List<Student> Students = new List<Student>();
            List<Trainer> Trainers = new List<Trainer>();

            //// MAIN MENU ////
            string input; ;
            do
            {
                Console.Clear();
                Console.WriteLine("//////////////////////////////////");
                Console.WriteLine("Welcome to the main menu");
                Console.WriteLine("//////////////////////////////////");
                Console.WriteLine("Do you want to insert data yourself \n" +
                    "or let the system generate synthetic data? \n" +
                    "Type :     Y       to insert data yourself \n" +
                    "Type :     S       to insert synthetic data\n" +
                    "Type :     P       to print the available data\n" +
                    "Type :     E       to exit");
                input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("|-| COURSES |-|");
                        Console.WriteLine("Create a new Course\n" +
                            "||Type in the info of the Course||");
                        Course course = new Course(false);
                        Courses.Add(course);
                        Console.WriteLine("Do you want to add another COURSE \n" +
                            "Press      any key to add another COURSE\n" +
                            " Type :      N to exit\n");
                        input = Console.ReadLine();

                    } while (input != "N" && input != "n");

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("|-| STUDENTS |-|");
                        Console.WriteLine("Insert as many Students as you want");
                        Student student = new Student(false);
                        Students.Add(student);
                        Console.WriteLine("___________________________________");
                        Console.WriteLine("Match the student to one of the available Courses\n" +
                            "___________________________________" +
                            "\nType the number inside the -> <- \n" +
                            "to add the student to the correspinding Course");
                        Methods.MatchStudentToCourse(Courses, student);
                        Console.WriteLine("--->Do you want to add another STUDENT?<---\n" +
                            "Press      any key to add another STUDENT\n" +
                            "Type :      N to exit\n");
                        input = Console.ReadLine();

                    } while (input != "N" && input != "n");

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("|-| ASSIGNMENTS |-|");
                        Console.WriteLine("Insert as many Assignments as you want");
                        Assignment assignment = new Assignment(false);
                        Assignments.Add(assignment);
                        Console.WriteLine("___________________________________");
                        Console.WriteLine("Match the assignment to one of the available Courses\n" +
                            "___________________________________" +
                            "\nType the number inside the -> <- \n" +
                            "to add the student to the correspinding Course");
                        Methods.MatchAssignmentToCourse(Courses, assignment);
                        Methods.MatchAssignmentToStudent(Students, assignment);
                        Console.WriteLine("Do you want to add another ASSIGNMENT?\n" +
                            "Press      any key to add another ASSIGNMENT\n" +
                            "Type :      N to exit\n");
                        input = Console.ReadLine();

                    } while (input != "N" && input != "n");

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("|-| TRAINERS |-|");
                        Console.WriteLine("Insert as many Trainers as you want");
                        Trainer trainer = new Trainer(false);
                        Trainers.Add(trainer);
                        Console.WriteLine("___________________________________");
                        Console.WriteLine("Match the student to one of the available Courses\n" +
                            "___________________________________" +
                            "\nType the number inside the -> <- \n" +
                            "to add the student to the correspinding Course");
                        Methods.MatchTrainerToCourse(Courses, trainer);
                        Console.WriteLine("Do you want to add another TRAINER?\n" +
                            "Press      any key to add another TRAINER\n" +
                            "Type :      N to exit\n");
                        input = Console.ReadLine();

                    } while (input != "N" && input != "n");

                }

                else if (input == "S" || input == "s")
                {
                    for (int i = 0; i < 2; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Course course = new Course(true);
                        Courses.Add(course);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Student student = new Student(true);
                        Students.Add(student);
                        if (i % 2 != 0)
                        {
                            Courses[0].StudentsPerCourse.Add(student);
                        }
                        else
                        {
                            Courses[0].StudentsPerCourse.Add(student);
                            Courses[1].StudentsPerCourse.Add(student);
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Assignment assignment = new Assignment(true);
                        Assignments.Add(assignment);
                        if (i % 2 == 0)
                        {
                            Courses[0].AssignmentsPerCourse.Add(assignment);
                            Students[i + 1].AssignmentsPerStudent.Add(assignment);
                        }
                        else
                        {
                            Courses[1].AssignmentsPerCourse.Add(assignment);
                            Students[i + 2].AssignmentsPerStudent.Add(assignment);
                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Trainer trainer = new Trainer(true);
                        Trainers.Add(trainer);
                        if (i % 2 != 0)
                        {
                            Courses[0].TrainersPerCourse.Add(trainer);
                        }
                        else
                        {
                            Courses[1].TrainersPerCourse.Add(trainer);
                        }
                    }
                    Console.WriteLine("--------------------------------------------\n" +
                            "Random Data inserted into the system.\n" +
                            "--------------------------------------------\n" +
                            "Press any key to return to the Main Menu");
                    Console.ReadLine();
                }
                else if (input == "P" || input == "p")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("//////////////////////////////////");
                        Console.WriteLine("DATA PRINT MENU");
                        Console.WriteLine("//////////////////////////////////");
                        Console.WriteLine(
                            "Type :     (1)       to print all the enrolled Students \n" +
                            "Type :     (2)       to print all the available Trainers\n" +
                            "Type :     (3)       to print all the Assignments\n" +
                            "Type :     (4)       to print all the available Courses\n" +
                            "Type :     (5)       to print a list of all the Students in each course\n" +
                            "Type :     (6)       to print a list of all the Trainers in each course\n" +
                            "Type :     (7)       to print a list of all the Assignments in each course\n" +
                            "Type :     (8)       to print a list of all the Assignments per Student\n" +
                            "Type :     (9)       to print a list of all the Students enrolled in more than one Course\n" +
                            "Type :     (0)       to print a list of all the Students that need to submit assignments this week\n" +
                            "Type :     (E)       to Exit the Print Menu\n");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("|||A list of all the enrolled students|||");
                            foreach (Student student in Students)
                            {
                                Console.WriteLine("_________________________");
                                student.PrintData();
                                Console.WriteLine("_________________________");
                            }
                            Console.ReadLine();
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("|||A list of all the Trainers|||");
                            foreach (Trainer trainer in Trainers)
                            {
                                Console.WriteLine("_________________________");
                                trainer.PrintData();
                                Console.WriteLine("_________________________");
                            }
                            Console.ReadLine();
                        }
                        else if (input == "3")
                        {
                            Console.WriteLine("|||A list of all the assignments|||");
                            foreach (Assignment assignment in Assignments)
                            {
                                Console.WriteLine("_________________________");
                                assignment.PrintData();
                                Console.WriteLine("_________________________");
                            }
                            Console.ReadLine();
                        }
                        else if (input == "4")
                        {
                            Console.WriteLine("|||A list of all the available Courses|||");
                            foreach (Course course in Courses)
                            {
                                Console.WriteLine("_________________________");
                                course.PrintData();
                                Console.WriteLine("_________________________");
                            }
                            Console.ReadLine();
                        }
                        else if (input == "5")
                        {
                            int count = Courses.Count;
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("|||A list of all the students in each course|||");
                                Console.WriteLine("____________________________________");
                                Console.WriteLine($"The Course {Courses[i].Title} has\n" +
                                    $"{Courses[i].StudentsPerCourse.Count} Students");
                                Console.WriteLine("____________________________________");
                                foreach (Student student in Courses[i].StudentsPerCourse)
                                {
                                    Console.WriteLine("/////////////////////////////////");
                                    student.PrintData();
                                    Console.WriteLine("/////////////////////////////////");
                                }
                            }
                            Console.ReadLine();
                        }
                        else if (input == "6")
                        {
                            Console.WriteLine("|||A list of all the Trainers in each course|||");

                            int count = Courses.Count;
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("____________________________________");
                                Console.WriteLine($"The Course {Courses[i].Title} has\n" +
                                    $"{Courses[i].TrainersPerCourse.Count} Trainers");
                                Console.WriteLine("____________________________________");
                                foreach (Trainer trainer in Courses[i].TrainersPerCourse)
                                {
                                    Console.WriteLine("/////////////////////////////////");
                                    trainer.PrintData();
                                    Console.WriteLine("/////////////////////////////////");
                                }
                            }
                            Console.ReadLine();
                        }
                        else if (input == "7")
                        {
                            Console.WriteLine("|||A list of all the Assignments in each course|||");
                            int count = Courses.Count;
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("____________________________________");
                                Console.WriteLine($"The Course {Courses[i].Title} has\n" +
                                    $"{Courses[i].AssignmentsPerCourse.Count} Assignments");
                                Console.WriteLine("____________________________________");
                                foreach (Assignment assignment in Courses[i].AssignmentsPerCourse)
                                {
                                    Console.WriteLine("/////////////////////////////////");
                                    assignment.PrintData();
                                    Console.WriteLine("/////////////////////////////////");
                                }
                            }
                            Console.ReadLine();
                        }
                        else if (input == "8")
                        {
                            int count = Students.Count;
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("____________________________________");
                                Console.WriteLine($"The Student ->{Students[i].FirstName} - {Students[i].LastName}<- has\n" +
                                    $"{Students[i].AssignmentsPerStudent.Count} Assignments");
                                Console.WriteLine("____________________________________");
                                foreach (Assignment assignment in Students[i].AssignmentsPerStudent)
                                {
                                    if (Students[i].AssignmentsPerStudent.Count == 0)
                                    {
                                        Console.WriteLine("/////////////////////////////////");
                                        Console.WriteLine($"The Student ->{Students[i].FirstName} - {Students[i].LastName}<-\n" +
                                            $"has 0 assignments");
                                        Console.WriteLine("/////////////////////////////////");
                                    }

                                }
                            }
                            Console.ReadLine();
                        }
                        else if (input == "9")
                        {
                            List<Student> StudensInMultipleCourses = new List<Student>();
                            int count = Students.Count;

                            for (int i = 0; i < count; i++)
                            {
                                int counter = 0;
                                foreach (Course course in Courses)
                                {

                                    if (course.StudentsPerCourse.Contains(Students[i]))
                                    {
                                        counter++;
                                        if (counter == 2)
                                        {
                                            StudensInMultipleCourses.Add(Students[i]);
                                            break;
                                        }

                                    }
                                }
                            }
                            Console.WriteLine("/////////////////////////////////");
                            Console.WriteLine("The students that belong to more than one Course are:");
                            Console.WriteLine("/////////////////////////////////");
                            foreach (Student student in StudensInMultipleCourses)
                            {
                                student.PrintData();
                            }
                            Console.ReadLine();
                        }
                        else if (input == "0")
                        {
                            List<Student> Submisions = new List<Student>();

                            DateTime dateValue = Methods.GetDateToCheck();
                            DayOfWeek givenDate = dateValue.DayOfWeek;
                            int givenDateTillMonday = givenDate - DayOfWeek.Monday;
                            DateTime firstWeekDay = dateValue.AddDays(-givenDateTillMonday);
                            DateTime lastWeekDay = firstWeekDay.AddDays(6);
                            int count = Students.Count;
                            for (int i = 0; i < count; i++)
                            {
                                foreach (Assignment assignment in Students[i].AssignmentsPerStudent)
                                {
                                    if (assignment.SubmisionDateTime.Date >= firstWeekDay && assignment.SubmisionDateTime.Date <= lastWeekDay)
                                    {
                                        Submisions.Add(Students[i]);
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("/////////////////////////////////");
                            Console.WriteLine("The students that need to submit assignments this week are:");
                            Console.WriteLine("/////////////////////////////////");
                            foreach (Student student in Submisions)
                            {
                                student.PrintData();
                            }
                            Console.ReadLine();
                        }
                        else break;
                    } while (input != "E" && input != "e");
                }
            } while (input != "E" && input != "e");
        }
    }
}
