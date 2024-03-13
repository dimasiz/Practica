using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public struct Accauntant
    {
        public enum Post
        {
            Manager = 220,
            Senior = 200,
            Junior = 160,
            Middle = 170
        }
        public bool AskForBonus(Post worker, int hours)
        {
            int requiredHours = (int)worker;

            if (hours < requiredHours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
