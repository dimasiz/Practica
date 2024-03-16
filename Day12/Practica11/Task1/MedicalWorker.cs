using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   abstract class MedicalWorker
    {
        protected string name;
        protected string post;

        public MedicalWorker(string name, string post) 
        { 
            this.name = name;
            this.post = post;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
    }
}
