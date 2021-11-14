using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{

    class Assignment
    {
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal DateTime SubmisionDateTime { get; set; }
        internal int OralMark { get; set; }
        internal int TotalMark { get; set; }

        public Assignment() { }
        public Assignment(bool random)
        {
            if (random)
            {
                Title = SyntheticData.GetRandomAssignment().Title;
                Description = SyntheticData.GetRandomAssignment().Description;
                SubmisionDateTime = SyntheticData.GetRandomAssignment().SubmisionDateTime;
                OralMark = SyntheticData.GetRandomAssignment().OralMark;
                TotalMark = SyntheticData.GetRandomAssignment().TotalMark;
            }
            else
            {
                Title = Methods.GetAssignmentTitle();
                Description = Methods.GetAssignmentDescription();
                SubmisionDateTime = Methods.GetSubmisionDate();
                OralMark = Methods.GetAssignmentOralMark();
                TotalMark = Methods.GetAssignmentTotalMark();
            }
        }
        public void PrintData()
        {
            Console.WriteLine($"Assignment's Data\n\t\tAssignment's Title :\n\t\t{Title}\n\t\tAssignment's Description : {Description}\n\t\t" +
                $"Assignment's Submision Date : {SubmisionDateTime}\n\t\t" +
                $"Oral Mark : {OralMark}\n\t\tTotal Mark : {TotalMark}");
        }


    }
}
