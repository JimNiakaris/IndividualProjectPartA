using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class SyntheticData
    {


        public static List<Course> SyntheticCourses = new List<Course>()
        {
            new Course()
            {
                Title = "CB12",
                Stream = CourseStream.CSHARP,
                Type = CourseType.FullTime,
                StartDate = new DateTime(2021,5,2),
                EndDate = new DateTime(2021,8,2),
            },
            new Course()
            {
                Title = "CB13",
                Stream = CourseStream.CSHARP,
                Type = CourseType.PartTime,
                StartDate = new DateTime(2021,5,2),
                EndDate = new DateTime(2021,11,2)
            },
            new Course()
            {
                Title = "CB14",
                Stream = CourseStream.JAVASCRIPT,
                Type = CourseType.FullTime,
                StartDate = new DateTime(2021,10,11),
                EndDate = new DateTime(2022,2,11)
            },
            new Course()
            {
                Title = "CB15",
                Stream = CourseStream.PYTHON,
                Type = CourseType.FullTime,
                StartDate = new DateTime(2021,11,14),
                EndDate = new DateTime(2021,3,16)
            }

        };


        public static List<Trainer> SyntheticTrainers = new List<Trainer>()
        {
            new Trainer()
            {
                FirstName = "Antwnhs",
                LastName = "Achladis",
                Subject = TrainerSubject.CSS
            },
            new Trainer()
            {
                FirstName = "Aggelos",
                LastName = "Mantakas",
                Subject = TrainerSubject.DataArchitecture
            },
            new Trainer()
            {
                FirstName = "Anastasis",
                LastName = "Katakouzinos",
                Subject = TrainerSubject.HTML
            },
            new Trainer()
            {
                FirstName = "Giannis",
                LastName = "Cholidis",
                Subject = TrainerSubject.SQL
            },
            new Trainer()
            {
                FirstName = "Stella",
                LastName = "Grigoriadi",
                Subject = TrainerSubject.dotNet
            }
        };

        public static List<Student> SyntheticStudents = new List<Student>()
        {
            new Student()
            {
                FirstName = "Giorgos",
                LastName = "Kyriazis",
                DateOfBirth = new DateTime(1996,5,16),
                TuitionFees = 2500
            },
            new Student()
            {
                FirstName = "Anastasis",
                LastName = "Strouziotis",
                DateOfBirth = new DateTime(1991,12,23),
                TuitionFees = 2200
            },
            new Student()
            {
                FirstName = "Hraklis",
                LastName = "Adamidis",
                DateOfBirth = new DateTime(1987,1,2),
                TuitionFees = 2100
            },
            new Student()
            {
                FirstName = "Aris",
                LastName = "Dimitriadis",
                DateOfBirth = new DateTime(1998,7,7),
                TuitionFees = 2400
            },
            new Student()
            {
                FirstName = "Marios",
                LastName = "Vlachakis",
                DateOfBirth = new DateTime(1999,9,20),
                TuitionFees = 2500
            },
            new Student()
            {
                FirstName = "Panagiotis",
                LastName = "Papatheodorou",
                DateOfBirth = new DateTime(1994,10,2),
                TuitionFees = 2500
            },
            new Student()
            {
                FirstName = "Michalis",
                LastName = "Theodosis",
                DateOfBirth = new DateTime(1995,2,12),
                TuitionFees = 2000
            }
        };
        public static List<Assignment> SyntheticAssingments = new List<Assignment>()
        {
            new Assignment()
            {
                Title = "Assignment1",
                Description = "Random Description",
                SubmisionDateTime = DateTime.Now.AddDays(-6),
                OralMark = 100,
                TotalMark = 100
            },
            new Assignment()
            {
                Title = "Assignment2",
                Description = "Random Description",
                SubmisionDateTime = DateTime.Now.AddDays(-1),
                OralMark = 100,
                TotalMark = 100
            },
            new Assignment()
            {
                Title = "Assignment3",
                Description = "Random Description",
                SubmisionDateTime = DateTime.Now.AddDays(5),
                OralMark = 100,
                TotalMark = 100
            },
            new Assignment()
            {
                Title = "Project1",
                Description = "Random Description",
                SubmisionDateTime = DateTime.Now.AddDays(-5),
                TotalMark = 100
            },
            new Assignment()
            {
                Title = "Project2",
                Description = "Random Description",
                SubmisionDateTime = DateTime.Now.AddDays(1),
                OralMark = 100,
                TotalMark = 100
            }
        };
        public static Assignment GetRandomAssignment()
        {
            Random selector = new Random();
            int index = selector.Next(0, 4);
            Assignment assignment = SyntheticAssingments.ElementAt(index);
            return assignment;
        }
        public static Student GetRandomStudent()
        {
            Random selector = new Random();
            int index = selector.Next(0, 6);
            Student student = SyntheticStudents.ElementAt(index);
            return student;
        }

        public static Trainer GetRandomTrainer()
        {
            Random selector = new Random();
            int index = selector.Next(0, 4);
            Trainer trainer = SyntheticTrainers.ElementAt(index);
            return trainer;
        }

        public static Course GetRandomCourse()
        {
            Random selector = new Random();
            int index = selector.Next(0, 4);
            Course course = SyntheticCourses.ElementAt(index);
            return course;
        }
        //public static string GetRandomFirstName()
        //{
        //    Random selector = new Random();
        //    int picker = selector.Next(0, 18);
        //    string firstname = Convert.ToString((FirstNames)picker);
        //    return firstname;
        //}

        //public static string GetRandomLastName()
        //{
        //    Random selector = new Random();
        //    int picker = selector.Next(0, 11);
        //    string lastname = Convert.ToString((LastNames)picker);
        //    return lastname;
        //}
        //public static int GetRandomTuitions()
        //{
        //    Random selector = new Random();
        //    int picker = selector.Next(0, 2);
        //    int tuitions;
        //    if (picker == 0)
        //    {
        //        tuitions = (int)Tuitions.Full;
        //        return tuitions;
        //    }
        //    else if (picker == 1)
        //    {
        //        tuitions = (int)Tuitions.reduced1;
        //        return tuitions;
        //    }
        //    else
        //    {
        //        tuitions = (int)Tuitions.reduced2;
        //        return tuitions;
        //    }

        //}

        //public static DateTime GetRandomDates()
        //{
        //    Random selector = new Random();
        //    int day = selector.Next(1, 30);
        //    int month = selector.Next(1, 12);
        //    int year = selector.Next(2019, 2022);
        //    DateTime randomDate = new DateTime(year, month, day);
        //    return randomDate;
        //}
        //public static CourseStream GetRandomCourseStream()
        //{
        //    Random selector = new Random();
        //    int courseStream = selector.Next(0, 3);
        //    CourseStream randCourseStream = (CourseStream)courseStream;
        //    return randCourseStream;
        //}


        //public static CourseType GetRandomCourseType()
        //{
        //    Random selector = new Random();
        //    int courseType = selector.Next(0, 1);
        //    CourseType randCourseType = (CourseType)courseType;
        //    return randCourseType;
        //}

        //public static string GetRandomCourseTitle()
        //{
        //    Random selector = new Random();
        //    int courseTitle = selector.Next(0, 3);
        //    string randCourseTitle = Convert.ToString((CourseTitle)courseTitle);
        //    return randCourseTitle;
        //}

        //public static TrainerSubject GetRandomTrainerSubject()
        //{
        //    Random selector = new Random();
        //    int trainerSubj = selector.Next(0, 5);
        //    TrainerSubject randTrainerSubj = (TrainerSubject)trainerSubj;
        //    return randTrainerSubj;
        //}




    }
}

