using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Prototype : ICloneable
    {
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> Activities { get; set; }

        public Prototype()
        {
            Activities = new List<string>();
        }

        public void AddActivity(string activity)
        {
            Activities.Add(activity);
        }

        public void RemoveActivity(string activity)
        {
            Activities.Remove(activity);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public abstract void PrintInfo();
    }
}

