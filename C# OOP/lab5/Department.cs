using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
     struct Department
    {
        private string deptName;
        private string manager;
        private Employee[] staff;
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }




        public Employee[] Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        public Department (int _id,string _deptName, string _manager, Employee[] _staff)
        {
            deptName = _deptName;
            manager = _manager;
            staff = _staff;
            id = _id;
        }

        public void PrintDepartment()
        {
            Console.WriteLine($"department name is {deptName} , manager is {manager} ");

        }
        public void PrintStaff()
        {
            for(int i =  0; i < staff.Length; i++)
            {

                Console.WriteLine(staff[i]);
            }
        }
        public void printNumOfEmployees(Employee[] emps)
        {
           int count = emps.Length-1;
            Console.WriteLine(count);
        }


        public void DisplayEmployees()
        {
            Console.WriteLine($"Employees in {deptName} department (Managed by {manager}):");

          
            }
        }

    }

