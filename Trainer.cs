using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    enum TrainerSubject
    {
        DataArchitecture,
        SQL,
        HTML,
        dotNet,
        CSS,
        Javascript
    }
    class Trainer
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal TrainerSubject Subject { get; set; }


        public Trainer() { }
        public Trainer(bool random)
        {
            if (random)
            {
                FirstName = SyntheticData.GetRandomTrainer().FirstName;
                LastName = SyntheticData.GetRandomTrainer().LastName;
                Subject = SyntheticData.GetRandomTrainer().Subject;
            }
            else
            {
                FirstName = Methods.GetFirstName();
                LastName = Methods.GetLastName();
                Subject = Methods.GetTrainerSubject();
            }
        }
        public void PrintData()
        {
            Console.WriteLine($" Trainer's Data : \n\t\tFirst Name :{FirstName}\n\t\tLast Name :" +
                $"{LastName}\n\t\tTrainer subject : {Subject}");
        }
    }
}
