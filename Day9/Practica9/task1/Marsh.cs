using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
     struct Marsh
    {
            public Marsh(int MarshNumber, string MarshBegin, string MarshEnd)
            {
                this.MarshNumber = MarshNumber;
                this.MarshBegin = MarshBegin;
                this.MarshEnd = MarshEnd;
            }

            public int MarshNumber { get; set; }
            public string MarshBegin { get; set; }
            public string MarshEnd { get; set; }

            public string WatchMarsh()
            {

                return this.MarshNumber + " " + this.MarshBegin + "-" + this.MarshEnd;
            }
        
    }
}
