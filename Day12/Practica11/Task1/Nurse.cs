using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Nurse : MedicalWorker
    {
        private int hours;

        public Nurse(string name, string post, int hours) : base(name, post)
        {
            this.hours = hours;
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        public virtual int GetSalary()
        {
            return Hours * 8;
        }

        public virtual void GetDisplayInfo()
        {
            Console.WriteLine($"Имя:{Name}\nПост:{Post}\nКолличвство Пацинтов в неделю:{Hours}");
        }

        
    }
}
