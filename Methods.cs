using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    static class Methods
    {


        public static string GetFirstName()
        {
            Regex reg = new Regex(@"^+[A-Z]|[a-z]{5,25}\z");
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            while (!reg.IsMatch(firstName))
            {
                Console.WriteLine("Enter a valid name between 5 and 25 charachters. Do not include numbers");
                firstName = Console.ReadLine();
            }
            return firstName.ToUpper();

        }
        public static string GetLastName()
        {
            Regex reg = new Regex(@"^+[A-Z]|[a-z]{5,25}\z");
            Console.WriteLine("Enter the last name");
            string lastName = Console.ReadLine();
            while (!reg.IsMatch(lastName))
            {
                Console.WriteLine("Enter a valid name between 5 and 25 charachters. Do not include numbers");
                lastName = Console.ReadLine();
            }
            return lastName.ToUpper();
        }
        public static DateTime GetBirthDate()
        {
            Console.WriteLine("Enter the student's birth date in the following" +
                "format: dd/mm/YYYY");
            string birthDate = Console.ReadLine();
            CultureInfo grCult = new CultureInfo("el-EL");
            while (!DateTime.TryParse(birthDate, out _))
            {
                Console.WriteLine("The date you entered was incorect.\n Try again.");
                birthDate = Console.ReadLine();
            }
            DateTime typedDT = DateTime.Parse(birthDate, grCult);
            if (DateTime.Now.Year - typedDT.Year < 18)
            {
                Console.WriteLine("All the students must be over 18.\n Try again.");
            }

            return typedDT;
        }
        public static int GetTuitionFees()
        {
            Regex reg = new Regex(@"^+[0-9]{1,4}\z");
            Console.WriteLine("Enter the tuitions fees of the student");
            string tuitionFee = Console.ReadLine();
            while (!reg.IsMatch(tuitionFee))
            {
                Console.WriteLine("!The tuition fee cannot include letters and cannot be more than 4 digits!");
                tuitionFee = Console.ReadLine();
            }

            return Convert.ToInt32(tuitionFee);
        }

        public static string GetCourseName()
        {
            Regex reg = new Regex(@"^+CB+[0-9]{1,2}\z");
            Console.WriteLine("Enter the course name. Example: CB9");
            string courseName = Console.ReadLine().ToUpper();
            while (!reg.IsMatch(courseName))
            {
                Console.WriteLine("Enter a valid course name like this : CB12");
                courseName = Console.ReadLine();
            }
            return courseName;
        }
        public static CourseStream GetCourseStream()
        {
            Console.WriteLine("Choose the course's stream. The available choices are:\n 0\t C#,\n" +
                "1\t Java,\n 2\t Javascript \n 3\t for Python");
            string courseStream = Console.ReadLine();
            Regex reg = new Regex(@"^[0-3]{1}");
            while (!reg.IsMatch(courseStream))
            {
                Console.WriteLine("Please choose one of the choices listed above");
                courseStream = Console.ReadLine();
            }
            return (CourseStream)int.Parse(courseStream);
        }

        public static CourseType GetCourseType()
        {
            Console.WriteLine("Choose the course's type. The available choices are:\n 0 \tFull Time"
               + "\n and 1 \tPart Time");
            string courseType = Console.ReadLine();
            Regex reg = new Regex(@"^[0-1]{1}");
            while (!reg.IsMatch(courseType))
            {
                Console.WriteLine("Please choose one of the choices listed above");
                courseType = Console.ReadLine();
            }
            return (CourseType)int.Parse(courseType);
        }

        public static DateTime GetStartDate()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the starting date of the course in the following" +
                "format: dd/mm/YYYY");
            Console.WriteLine("___________________________________");
            string startDate = Console.ReadLine();
            CultureInfo grCult = new CultureInfo("el-EL");
            while (!DateTime.TryParse(startDate, out _))
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("The date you entered was incorect.\n Try again.");
                Console.WriteLine("___________________________________");
                startDate = Console.ReadLine();
            }
            DateTime typedDT = DateTime.Parse(startDate, grCult);
            return typedDT;
        }

        public static DateTime GetEndDate()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the ending date of the course in the following" +
                "format: dd/mm/YYYY");
            Console.WriteLine("___________________________________");
            string endDate = Console.ReadLine();
            CultureInfo grCult = new CultureInfo("el-EL");
            while (!DateTime.TryParse(endDate, out _))
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("The date you entered was incorect.\n Try again.");
                Console.WriteLine("___________________________________");
                endDate = Console.ReadLine();
            }
            DateTime typedDT = DateTime.Parse(endDate, grCult);
            return typedDT;
        }
        public static TrainerSubject GetTrainerSubject()
        {
            Console.WriteLine("Choose the trainer's subject. The available choices are:\n 0 \tDataArchitecture," +
                "1 \tSQL,\n 2 \tHTML \n 3 \tdotNet \n 4 \tCSS \n 5 \tJavascript");
            string trainerSubj = Console.ReadLine();
            Regex reg = new Regex(@"^[0-5]{1}");
            while (!reg.IsMatch(trainerSubj))
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("Please choose one of the choices listed above");
                Console.WriteLine("___________________________________");
                trainerSubj = Console.ReadLine();
            }
            return (TrainerSubject)int.Parse(trainerSubj);
        }

        public static string GetAssignmentTitle()
        {
            Regex reg = new Regex(@"^+[A-Za-z]{5,25}\z");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the assignment's title");
            Console.WriteLine("___________________________________");
            string asTitle = Console.ReadLine();
            while (!reg.IsMatch(asTitle))
            {
                Console.WriteLine("//// Enter a valid Title between 5 and 25 charachters. Do not include numbers ////");
                asTitle = Console.ReadLine();
            }
            return asTitle.ToUpper();

        }
        public static string GetAssignmentDescription()
        {
            Regex reg = new Regex(@"^+[A-Za-z]{5,25}\z");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the assignment's Description");
            Console.WriteLine("___________________________________");
            string asDescr = Console.ReadLine();
            while (!reg.IsMatch(asDescr))
            {
                Console.WriteLine("//// Enter a valid Description between 5 and 25 charachters. Do not include numbers ////");
                asDescr = Console.ReadLine();
            }
            return asDescr.ToUpper();
        }
        public static DateTime GetSubmisionDate()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the Submision date of the Assignment in the following" +
                "format: dd/mm/YYYY");
            Console.WriteLine("___________________________________");
            string subDate = Console.ReadLine();
            CultureInfo grCult = new CultureInfo("el-EL");
            while (!DateTime.TryParse(subDate, out _))
            {
                Console.WriteLine("////The date you entered was incorect.////\n Try again.");
                subDate = Console.ReadLine();
            }
            DateTime typedDT = DateTime.Parse(subDate, grCult);
            return typedDT;
        }
        public static DateTime GetDateToCheck()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the Submision date in the following" +
                "format: dd/mm/YYYY");
            Console.WriteLine("___________________________________");
            string subDate = Console.ReadLine();
            CultureInfo grCult = new CultureInfo("el-EL");
            while (!DateTime.TryParse(subDate, out _))
            {
                Console.WriteLine("////The date you entered was incorect.////\n Try again.");
                subDate = Console.ReadLine();
            }
            DateTime typedDT = DateTime.Parse(subDate, grCult);
            return typedDT;
        }
        public static int GetAssignmentOralMark()
        {
            Regex reg = new Regex(@"^+[0-9]{1,3}\z");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the Assignment's oral mark");
            Console.WriteLine("___________________________________");
            string oralMark = Console.ReadLine();
            while (!reg.IsMatch(oralMark))
            {
                Console.WriteLine("////!The Mark cannot include letters and cannot be more than 3 digits!////");
                oralMark = Console.ReadLine();
            }
            return Convert.ToInt32(oralMark);
        }
        public static int GetAssignmentTotalMark()
        {
            Regex reg = new Regex(@"^+[0-9]{1,3}\z");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Enter the Assignment's oral mark");
            Console.WriteLine("___________________________________");
            string totalMark = Console.ReadLine();
            while (!reg.IsMatch(totalMark))
            {
                Console.WriteLine("////!The Mark cannot include letters and cannot be more than 3 digits!////");
                totalMark = Console.ReadLine();
            }
            return Convert.ToInt32(totalMark);
        }
        public static void MatchStudentToCourse(List<Course> Courses, Student student)
        {
            int count = Courses.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"-> {i} <-");
                Courses[i].PrintData();
            }

            if (Int32.TryParse((Console.ReadLine()), out int courseId))
            {
                Courses[courseId].StudentsPerCourse.Add(student);
                Console.WriteLine("___________________________________\n" +
                    "Success!! The student was matched to the selected Course");
                Console.WriteLine("___________________________________");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("////Please type one of the numbers inside the -> <- ////");
                Console.ReadLine();
            }
        }

        public static void MatchAssignmentToCourse(List<Course> Courses, Assignment assignemnt)
        {
            int count = Courses.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"-> {i} <-");
                Courses[i].PrintData();
            }

            if (Int32.TryParse((Console.ReadLine()), out int courseId))
            {
                Courses[courseId].AssignmentsPerCourse.Add(assignemnt);
                Console.WriteLine("___________________________________\n" +
                    "Success!! The assignment was matched to the selected Course");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("////Please type one of the numbers inside the -> <-////");
                Console.ReadLine();
            }
        }

        public static void MatchAssignmentToStudent(List<Student> Students, Assignment assignemnt)
        {
            int count = Students.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"-> {i} <-");
                Students[i].PrintData();
            }
            if (Int32.TryParse((Console.ReadLine()), out int studentId))
            {
                Students[studentId].AssignmentsPerStudent.Add(assignemnt);
                Console.WriteLine("___________________________________\n" +
                    "Success!! The assignment was matched to the selected Student");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("////Please type one of the numbers inside the -> <-////");
                Console.ReadLine();
            }
        }
        public static void MatchTrainerToCourse(List<Course> Courses, Trainer trainer)
        {
            int count = Courses.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"-> {i} <-");
                Courses[i].PrintData();
            }

            if (Int32.TryParse((Console.ReadLine()), out int trainerId))
            {
                Courses[trainerId].TrainersPerCourse.Add(trainer);
                Console.WriteLine("___________________________________\n" +
                    "Success!! The trainer was matched to the selected Course");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("////Please type one of the numbers inside the -> <-////");
                Console.ReadLine();
            }
        }








        //public static Student CreateStudent(bool random)
        //{
        //    Student student = new Student(random);
        //    Course.Students.Add(student);
        //    return student;
        //}
        //public static Assignment CreateAssignment(bool random)
        //{
        //    Assignment assignment = new Assignment(random);
        //    Course.Assignments.Add(assignment);
        //    return assignment;
        //}
        //public static Trainer CreateTrainer(bool random)
        //{
        //    Trainer trainer = new Trainer(random);
        //    Course.Trainers.Add(trainer);
        //    return trainer;
        //}

        //public static Course CreateNewCourse(bool random, List<Student> student, List<Trainer> trainer, List<Assignment> assignment)
        //{
        //    Course course = new Course(random, student, trainer, assignment);
        //    Course.Courses.Add(course);
        //    return course;
        //}





    }

}
