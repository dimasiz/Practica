using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.models;

namespace WpfApp1
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);

        void Add(Country country);

        void Delete(string name);

        Country FindBy(string name);

        List<Country> GetAll();
    }
}



