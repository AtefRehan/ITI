using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    struct Company
    {

        private string companyName;


        private Department[] departments;

        public Department[] Departments
        {
            get { return departments; }
            set { departments = value; }
        }


        public Company(string _companyName, Department[] _departments)
        {
            companyName = _companyName;
            departments = _departments;
        }
    }
}
