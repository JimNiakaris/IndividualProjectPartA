using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        internal List<Assignment> AssignmentsPerStudent { get; set; }

        public Student() { }
        public Student(bool random)
        {
            if (random)
            {
                FirstName = SyntheticData.GetRandomStudent().FirstName;
                LastName = SyntheticData.GetRandomStudent().LastName;
                DateOfBirth = SyntheticData.GetRandomStudent().DateOfBirth;
                TuitionFees = SyntheticData.GetRandomStudent().TuitionFees;
                AssignmentsPerStudent = new List<Assignment>();
            }

            else
            {
                FirstName = Methods.GetFirstName();
                LastName = Methods.GetLastName();
                DateOfBirth = SyntheticData.GetRandomStudent().DateOfBirth;
                TuitionFees = Methods.GetTuitionFees();
                AssignmentsPerStudent = new List<Assignment>();
            }

        }

        public void PrintData()
        {
            Console.WriteLine($" Student's Data : \n\t\tFirst Name :{FirstName}\n\t\tLast Name :" +
                $"{LastName} \n\t\tTuitions fees : {TuitionFees}");
        }

    }
}
