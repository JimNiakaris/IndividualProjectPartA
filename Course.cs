using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{

    public enum CourseStream
    {
        CSHARP,
        JAVA,
        JAVASCRIPT,
        PYTHON
    }
    public enum CourseType
    {
        FullTime,
        PartTime
    }
    public class Course
    {

        public string Title { get; set; }
        public CourseStream Stream { get; set; }
        public CourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        internal List<Student> StudentsPerCourse { get; set; }
        internal List<Trainer> TrainersPerCourse { get; set; }
        internal List<Assignment> AssignmentsPerCourse { get; set; }

        public Course() { }
        public Course(bool random)
        {
            if (random)
            {
                Title = SyntheticData.GetRandomCourse().Title;
                Stream = SyntheticData.GetRandomCourse().Stream;
                Type = SyntheticData.GetRandomCourse().Type;
                StartDate = SyntheticData.GetRandomCourse().StartDate;
                EndDate = SyntheticData.GetRandomCourse().EndDate;
                StudentsPerCourse = new List<Student>();
                TrainersPerCourse = new List<Trainer>();
                AssignmentsPerCourse = new List<Assignment>();

            }
            else
            {
                Title = Methods.GetCourseName();
                Stream = Methods.GetCourseStream();
                Type = Methods.GetCourseType();
                StartDate = Methods.GetStartDate();
                EndDate = Methods.GetEndDate();
                StudentsPerCourse = new List<Student>();
                TrainersPerCourse = new List<Trainer>();
                AssignmentsPerCourse = new List<Assignment>();
            }
        }

        public void PrintData()
        {
            Console.WriteLine($"______________________________________________________________\n" +
                $"Course's Data : \n\t\tCourse Title : {Title}\n\t\tCourse Stream : {Stream}\n\t\t" +
                $"Course Type : {Type}\n\t\tCourse Start Date : {StartDate}\n\t\tCourse End Date : {EndDate}");
        }
    }
}
