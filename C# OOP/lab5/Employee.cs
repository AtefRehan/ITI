using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab4.Program;

namespace lab4
{

    public struct Employee
    {
        private string name;
        private int id;
        private string securityLevel;
        private float salary;
        private HiringDate hiringDate;
        private string gender;




        public Employee(string _name, int _id, string _securityLevel, float _salary, HiringDate _hiringDate, string _gender)
        {
            name = _name;
            id = _id;
            securityLevel = _securityLevel;
            salary = _salary;
            hiringDate = _hiringDate;
            gender = _gender;

        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setSecurityLevel(string _securityLevel)
        {
            if (_securityLevel != "guest" && _securityLevel != "developer" && _securityLevel != "secertary" && _securityLevel != "DBA")
            {
                Console.WriteLine("you have entered a wrong input");
            }
            securityLevel = _securityLevel;
        }
        public void DeleteEmployee()
        {
            name = null;
            id = 0;
            salary= 0;
            securityLevel= null;
            gender= null;
            hiringDate.Day = 0;
            hiringDate.Month = 0;
            hiringDate.Year = 0;
            
                
        }
        public string getSecurityLevel()
        {
            //Console.WriteLine(securityLevel);
            return securityLevel;
        }
        public void setGender(String Gender)
        {
            if (Gender != "male" && Gender != "female")
            {
                Console.WriteLine("Wrong input please choose between male and female");
            }
            gender = Gender;
        }
        public string getGender()
        {
            //Console.WriteLine(gender);
            return gender;
        }

        public void setId(int _id)
        {
            id = _id;
        }
        public int getId()
        {
            return id;
        }

        public void setSalary(float _salary)
        {
            salary = _salary;

        }
        public float getSalary()
        {
            return salary;
        }

        public void setHiringDate(HiringDate _hiringDate)
        {
            hiringDate = _hiringDate;
        }
        public HiringDate GetHiringDate()
        {
            return hiringDate;
        }
        public void printEmployee()
        {
            Console.WriteLine($"name is {getName()}");
            Console.WriteLine($"id is {getId()} ");
            Console.WriteLine($"Gender is {getGender()}");
            Console.WriteLine($"Salary is  {getSalary()}");

            Console.WriteLine($"Security level is {getSecurityLevel()}");

            Console.WriteLine($" {hiringDate.printHiringDay()} ");

        }



    }

}
