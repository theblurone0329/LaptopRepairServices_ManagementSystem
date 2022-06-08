using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Repair_Services_Management_System
{
    class StoreAccDetails
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string getAccName()
        {
            return Name;
        }

        public StoreAccDetails(string Name)
        {
            this.name = Name;
        }
    }
}
