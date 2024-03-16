using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Doctor : MedicalWorker
    {
        private int numberPatients;


        public Doctor(string name, string post, int numberPatients) : base(name,post)
        {
            this.numberPatients = numberPatients;
        }
        public int NumberPatients
        {
            get { return numberPatients; }
            set { numberPatients = value; }
        }


        public virtual void GetSalary()
        {
            Console.WriteLine($"Принимает пацинтов в неделю:{numberPatients * 8}");
        }

        public virtual void GetDisplayInfo()
        {
            Console.WriteLine($"Имя:{Name}\nПост:{Post}\nКолличвство Пацинтов в неделю:{NumberPatients}");
        }


    }
}
