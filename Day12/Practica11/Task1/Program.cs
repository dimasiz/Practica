using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Program
    {
        static void Main(string[] args)
        {
            
            List<Doctor> listDoctors = new List<Doctor>();
            List<Nurse> listNurser = new List<Nurse>();


            Doctor doctor1 = new Doctor("Коварх Глеб", "Педиатр", 21);
            Doctor doctor2 = new Doctor("Шамсутдинов Ренат", "Хирург", 39);
            Doctor doctor3 = new Doctor("Швеудо Дмитрий", "Добрый",45);
            Nurse nurse1 = new Nurse("Полина","Медсестра",34);
            Nurse nurse2 = new Nurse("Милена", "Фельдшер-окушер", 13);
            listDoctors.Add(doctor1);
            listDoctors.Add(doctor2);
            listDoctors.Add(doctor3);
            listNurser.Add(nurse2);
            listNurser.Add(nurse1);

            foreach (var doctorWorker in listDoctors)
            {
                doctorWorker.GetDisplayInfo();
                doctorWorker.GetSalary();
            }


            foreach (var nurserWorker in listNurser)
            {
                nurserWorker.GetDisplayInfo();
                Console.WriteLine($"Выручка:{nurserWorker.GetSalary()}");
            }


            int count = 0;

            foreach(var SalaryWorker in listNurser)
            {
                count += SalaryWorker.GetSalary();
            }
            Console.WriteLine($"Общая выручка медсистер:{count}");
        }
    }
}
