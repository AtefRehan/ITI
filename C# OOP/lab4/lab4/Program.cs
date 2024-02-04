using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        public struct Employee
        {
            private string name;
            private int id;
            private string securityLevel;
            private float salary;
            private HiringDate hiringDate;
            private string gender;

            //public string Name { get; set; }
            //public int ID { get; set; }
            //public string SecurityLevel { get; set; }
            //public float Salary { get; set; }
            //public HiringDate HiringDate { get; set; }
            //public string Gender { get; set; }


            public Employee(string _name, int _id, string _securityLevel, float _salary, HiringDate _hiringDate, string _gender )
            {
                name = _name;
                id= _id ;
                securityLevel= _securityLevel ; 
                salary= _salary ;
                hiringDate= _hiringDate ;
                gender= _gender ;

            }
            public void SetName(string _name)
            {
                name= _name;
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
                return hiringDate ;
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

            public void DeleteEmployee()
            {
                name = null;
                id = 0;
                salary = 0;
                securityLevel = null;
                gender = null;
                hiringDate.Day = 0;
                hiringDate.Month = 0;
                hiringDate.Year = 0;


            }



        }

        public struct HiringDate
        {
            //private int Day;
            //private int Month;
            //private int Year;
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HiringDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public string printHiringDay()
            {
                //Console.WriteLine($"HiringDate is {Day}/{Month}/{Year}");
                return ($"HiringDate is {Day}/{Month}/{Year}");
            }
            


        }

        static bool CheckUnique(Employee[] array, int userInput)
        {
            for (int i = 0; i < array.Length; i++)

            {
                if (array[i].getId() == userInput)
                {
                    return false;
                }
            }
            return true;
        }



        //public static bool CheckId(int[] userArray)
        //{

        //    for (int i = 0; i < userArray.Length; i++)
        //    {
        //        int userInput;

        //        while (true)
        //        {
        //            Console.Write($"Enter value {i + 1}: ");

        //            userInput = int.Parse(Console.ReadLine());
        //            if (CheckUnique(userArray, userInput))
        //            {
        //                //userArray[i] = userInput;
        //                //break;
        //                return true;

        //            }
        //            else
        //            {
        //                return false;
        //                Console.WriteLine("Value must be unique. Please try again.");
        //            }
        //        }
        //    }
        //    return false;
        //}


        public static Employee[] FillArrayOfEmp()
        {
            Console.WriteLine("enter array dimension");
            int size = int.Parse(Console.ReadLine());
            Employee[] emp1 = new Employee[size];
            HiringDate[] hiringDate = new HiringDate[size];
            int id;
            String gender;
            string securityLevel;
            string name;


            


            for (int i = 0; i < emp1.Length; i++)
            {
                Console.WriteLine($"Employee Number = {i + 1} Data\n");
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                emp1[i].SetName(name);
                
                do {
                    Console.WriteLine("Enter ID");
                     id = int.Parse(Console.ReadLine());
                }
                while (!CheckUnique(emp1, id));


                emp1[i].setId(id);


                do
                {
                    Console.WriteLine("Enter Gender");
                    gender = Console.ReadLine();
                } while (gender != "male" && gender!= "female");
                emp1[i].setGender(gender);

                Console.WriteLine("EnterSalary");
                emp1[i].setSalary(int.Parse(Console.ReadLine()));
                do {
                    Console.WriteLine("Enter Security Level");
                    securityLevel = Console.ReadLine();
                }
                while (securityLevel != "guest" && securityLevel != "developer" && securityLevel != "secertary" && securityLevel != "DBA");

                emp1[i].setSecurityLevel(securityLevel);


                Console.WriteLine("EnterHiringDate");
                emp1[i].setHiringDate(new HiringDate(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                //emp1[i].printEmployee();
            }
            for (int i = 0; i < emp1.Length; i++)
            {
                //emp1[i].printEmployee();
            }

            return emp1;

        }

        #region getconcat
        public static void GetConcatedArray(Employee[] array1, Employee[] array2)
        {
            Employee[] resultArray = new Employee[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i];
            }

            for (int j = 0; j < array2.Length; j++)
            {
                resultArray[array1.Length + j] = array2[j];
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                Employee employee = resultArray[i];
                //Console.WriteLine($"Id: {employee.getId()}, SecurityLevel: {employee.getSecurityLevel()}, Salary: {employee.getSalary()}, HiringDate: {employee.GetHiringDate()}, Gender: {employee.getGender()}");
                employee.printEmployee();
            }

        }


        #endregion

        #region Q5 
         public static void PrintArrayOfEmployees(Employee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Employee employee = arr[i];
                employee.printEmployee();
            }
        }
        #endregion

        #region Q6 Function Menu
        public static void GetEmpById(int id, Employee[] emp)
        {
            for(int i = 0;i < emp.Length;i++)
            {
                if (id == emp[i].getId())
                {

                     emp[i].printEmployee();
                }
            }
            //Console.WriteLine("can't find id");
        }
        public static void GetEmpByName(string name, Employee[] emp)
        {
            for(int i = 0;i < emp.Length;i++)
            {
                if (name == emp[i].getName())
                {

                     emp[i].printEmployee();
                }
            }
            //Console.WriteLine("can't find id");
        }

        public static int Count(Employee[] emp)
        {
            int count = 0;
            for(int i = 0;i<emp.Length;i++)
            {
                
                if (emp[i].Equals(null))
                {
                    count++;
                }
            }
            return count;
        }
        #endregion



        public static void UpdateEmpById(int id, Employee[] emp)
        {
            for (int i = 0; i < emp.Length; i++)
            {
                if (id == emp[i].getId())
                {

                    emp[i].printEmployee();
                    Console.WriteLine("Enter name :");
                    emp[i].SetName(Console.ReadLine());
                    Console.WriteLine("Enter gender");
                    emp[i].setGender(Console.ReadLine());
                    Console.WriteLine("Enter salary");
                    emp[i].setSalary(int.Parse(Console.ReadLine()));


                }
            }
            //Console.WriteLine("can't find id");
        }



        public static Employee[] DeleteEmpById(int id, Employee[] emp)
        {
            Employee[] arr = new Employee []{ };
            for (int i = 0; i < emp.Length; i++)
            {
                if (id == emp[i].getId())
                {
                    emp[i].DeleteEmployee();

                }
            }
            return arr;
        }

        //public static void Menu (char choice)
        //{



        //    Employee[] emp = new Employee[10];
        //    switch (choice)
        //    {
        //        case 'a':
        //           emp=  FillArrayOfEmp();
        //            Console.WriteLine("Array Filled !");
        //            break;
        //        case 'b':
        //            PrintArrayOfEmployees(emp);
        //            break;
        //        case 'c':
        //            Console.WriteLine("Enter name ");
        //            string name = Console.ReadLine();   
        //            GetEmpByName(name,emp);
        //            break;
        //        case 'd':
        //            Console.WriteLine("enter id ");
        //            int id = int.Parse(Console.ReadLine());
        //            GetEmpById(id,emp);
        //            break;
        //        case 'e':
        //            Count(emp);
        //            break;
        //        case 'f':
        //            Console.WriteLine("enter id ");
        //            int _id = int.Parse(Console.ReadLine());
        //            UpdateEmpById(_id,emp);
        //            break;
        //        case 'g':
        //            //DeleteEmployeeById();
        //            break;
        //        case 'h':
        //            Console.WriteLine("Exiting the program. Goodbye!");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}
        public static void Menu(char choice)
        {
            Employee[] emp = new Employee[] { };

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("a- Insert New Employee array");
                Console.WriteLine("b- Display inserted Employee");
                Console.WriteLine("c- Search For Employee by Name");
                Console.WriteLine("d- Search for Employee by ID");
                Console.WriteLine("e- Count Number of Empployees");
                Console.WriteLine("f- update employee by id ");
                Console.WriteLine("g- delete employee");
                Console.WriteLine("h- exit");


                Console.Write("Enter your choice (a-h): ");
                choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        emp = FillArrayOfEmp();
                        Console.WriteLine("Array Filled !");
                        break;
                    case 'b':
                        PrintArrayOfEmployees(emp);
                        break;
                    case 'c':
                        Console.WriteLine("Enter name ");
                        string name = Console.ReadLine();
                        GetEmpByName(name, emp);
                        break;
                    case 'd':
                        Console.WriteLine("enter id ");
                        int id = int.Parse(Console.ReadLine());
                        GetEmpById(id, emp);
                        break;
                    case 'e':
                        Count(emp);
                        break;
                    case 'f':
                        Console.WriteLine("enter id ");
                        int _id = int.Parse(Console.ReadLine());
                        UpdateEmpById(_id, emp);
                        break;
                    case 'g':
                        Console.WriteLine("enter id ");
                        int ID = int.Parse(Console.ReadLine());
                        DeleteEmpById(ID, emp);
                        break;
                    case 'h':
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            while (choice != 'g');
            }

        static void Main(string[] args)
        {
            #region Q1
            //Employee employee = new Employee();
            //employee.setId(200);
            //employee.setGender("male");
            //employee.setSalary(10000);
            //employee.setSecurityLevel("developer");
            //employee.setHiringDate(new HiringDate(16,6,2020));

            //employee.printEmployee();

            #endregion
            //FillArrayOfEmp();

            #region Q4
            //Employee[] emp1 = FillArrayOfEmp();
            //Employee[] emp2 = FillArrayOfEmp();
            //GetConcatedArray(emp1, emp2);

            #endregion

            #region Q5 print array of employees 
            HiringDate h1 = new HiringDate(3,3,2023);
            HiringDate h2 = new HiringDate(4,4,2023);
            
            Employee emp1 = new Employee("ahmed",1,"guest",3000,h1,"male");
            Employee emp2 = new Employee("sayeeeeeeed", 2,"developer",5000,h2,"female");

            Employee[] arrOfEmployees = { emp1, emp2 };

            //Employee[] arrOfEmployees2 = new Employee[10];
            //arrOfEmployees2[0] = emp1;
            //arrOfEmployees2[1] = emp2;
            //arrOfEmployees2[3] = emp2;
            //PrintArrayOfEmployees(arrOfEmployees);
            #endregion

            #region Q6 Menu 
            //GetEmpById(1, arrOfEmployees);
            //GetEmpByName("ahmed", arrOfEmployees);
            //Console.WriteLine("the count is " + Count(arrOfEmployees2));
            //UpdateEmpById(1, arrOfEmployees);


            Menu('a');
            #endregion

        }
    }
}