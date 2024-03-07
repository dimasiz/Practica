using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] residents = new int[12, 4];
            
            Random random = new Random();

          
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    residents[i, j] = random.Next(1, 6);
                    Console.WriteLine($"{residents[i,j]}");
                }

                Console.WriteLine();
            }


            int thirdFloorPeople = 0;
            int fiveFloorPeople= 0;

            for (int i = 0; i < 4; i++)
            {
                thirdFloorPeople += residents[2, i]; 
                fiveFloorPeople += residents[4, i]; 
            }

            
            string floorPeople;

            if (thirdFloorPeople > fiveFloorPeople)
            {
                floorPeople = "третьем";
            }
            else if (thirdFloorPeople < fiveFloorPeople)
            {
                floorPeople = "пятом";
            }
            else
            {
                floorPeople = "третьем и пятом, так как количество жильцов одинаково";
            }

          
            Console.WriteLine($"На  {floorPeople} больше людей ");
        }
    
    }
}
