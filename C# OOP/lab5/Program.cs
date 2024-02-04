using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {


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



            for (int i = 0; i < emp1.Length; i++)
            {
                Console.WriteLine($"Employee Number = {i + 1} Data\n");
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
                } while (gender != "male" && gender != "female");
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
            for (int i = 0; i < emp.Length; i++)
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
            for (int i = 0; i < emp.Length; i++)
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
            for (int i = 0; i < emp.Length; i++)
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



        //public static Employee[] DeleteEmpById(int id, Employee[] emp)
        //{
        //    Employee[] arr;
        //    for (int i = 0; i < emp.Length; i++)
        //    {
        //        if (id == emp[i].getId())
        //        {


        //            List<Employee> list = emp.ToList();
        //            list.Remove(emp[i]);
        //            arr=list.ToArray();

        //        }
        //    }
        //    return arr;
        //}

        public static void Menu(char choice)
        {
            Employee[] emp = new Employee[10];
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
                    //DeleteEmployeeById();
                    break;
                case 'h':
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }




        public static void DisplayAllDepartments(Department[] depts)
        {
            Console.WriteLine("Departments are ");
            for (int i = 0; i < depts.Length; i++)
            {
                depts[i].PrintDepartment();
            }
        }


        public static void DisplayEmpCountPerDept(Company company, int id)
        {
            int count = 0;
            for (int i = 0; i < company.Departments.Length; i++)
            {
                if (id == company.Departments[i].ID)
                {
                    count = company.Departments[i].Staff.Length;
                }
            }
            Console.WriteLine(count);
        }



        public static void DisplayTotalEmployees(Company company)
        {
            int count = 0;
            for (int i = 0; i < company.Departments.Length; i++)
            {

                count += company.Departments[i].Staff.Length;

            }
            Console.WriteLine(count);
        }



        public static void SearchEmpById(int id, Department deptName)
        {
            for (int i = 0; i < deptName.Staff.Length; i++)
            {
                if (id == deptName.Staff[i].getId())
                {

                    deptName.Staff[i].printEmployee();
                }
            }
        }

        public static void UpdateEmpByID(int id, Department deptName)
        {
            for (int i = 0; i < deptName.Staff.Length; i++)
            {
                if (id == deptName.Staff[i].getId())
                {
                    Console.WriteLine("Enter New Name");
                    deptName.Staff[i].SetName(Console.ReadLine());
                    Console.WriteLine($"New data is \n Name {deptName.Staff[i].getName()}" +
                        $"\n ID {deptName.Staff[i].getId()} \n salary {deptName.Staff[i].getSalary()}");
                }
            }
        }

        public static void DeleteEmpByID(int id, Department deptName)
        {
            for (int i = 0; i < deptName.Staff.Length; i++)
            {
                if (id == deptName.Staff[i].getId())
                {

                    deptName.Staff[i].DeleteEmployee();



                }
            }
        }

        #region last question (MENU)
        public static void menu2(char choice)
        {
            HiringDate h1 = new HiringDate(3, 3, 2023);
            HiringDate h2 = new HiringDate(4, 4, 2023);

            Employee emp1 = new Employee("ahmed", 1, "guest", 3000, h1, "female");
            Employee emp2 = new Employee("sayeeeeeeed", 2, "developer", 5000, h2, "female");
            Employee emp3 = new Employee("Atef", 3, "developer", 12000, h2, "male");
            Employee emp4 = new Employee("omar", 4, "developer", 3000, h2, "male");
            Employee emp5 = new Employee("maged", 5, "developer", 3000, h2, "male");
            Employee emp6 = new Employee("mohamed", 6, "developer", 3000, h2, "male");

            Employee[] arrOfEmployees = { emp1, emp2, emp3 };
            Employee[] arrOfEmployees2 = new Employee[] { emp4, emp5, emp6 };
            Department dept1 = new Department(1, "finance", "ahmed", arrOfEmployees);
            Department dept2 = new Department(2, "Management", "Atef", arrOfEmployees2);

            Department[] arrOfDepartments = { dept1, dept2 };

            Company Mycompany = new Company("my company", arrOfDepartments);
            Department dept;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("a- Display All Departments Names");
                Console.WriteLine("b- Display Employees Count Per Departments");
                Console.WriteLine("c- Display Total number of employees in company");
                Console.WriteLine("d- Search for Employee ID in Dept");
                Console.WriteLine("e- Update Employee Name in dept");
                Console.WriteLine("f- Delete employee by id");
                Console.WriteLine("g- Exit");

                Console.Write("Enter your choice (a-g): ");
                choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); // New line for readability

                switch (choice)
                {
                    case 'a':
                        DisplayAllDepartments(arrOfDepartments);
                        break;

                    case 'b':
                        DisplayEmpCountPerDept(Mycompany, 2);

                        break;

                    case 'c':
                        DisplayTotalEmployees(Mycompany);
                        break;

                    case 'd':
                        Console.Write("Enter Employee ID: ");
                        int employeeId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department between dept1 and dept2 ");
                        string deptNameForSearch = Console.ReadLine();
                        if(deptNameForSearch == "dept1")
                        {
                             dept = dept1;
                        }
                        else
                        {
                            dept = dept2;
                        }

                        SearchEmpById(employeeId,dept);

                        break;

                    case 'e':
                        Console.Write("Enter Employee ID: ");
                        int employeeIdForUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department Name: ");
                        string deptNameForUpdate = Console.ReadLine();
                        if (deptNameForUpdate == "dept1")
                        {
                            dept = dept1;
                        }
                        else
                        {
                            dept = dept2;
                        }
                        UpdateEmpByID(employeeIdForUpdate, dept);

                        break;

                    case 'f':
                        Console.Write("Enter Employee ID: ");
                        int employeeIdForDelete = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department Name: ");
                        string deptNameForDelete = Console.ReadLine();
                        if (deptNameForDelete == "dept1")
                        {
                            dept = dept1;
                        }
                        else
                        {
                            dept = dept2;
                        }
                        DeleteEmpByID(employeeIdForDelete, dept);
                        break;

                    case 'g':
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (choice != 'g');
        }
    



        #endregion
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
            
            Employee emp1 = new Employee("ahmed",1,"guest",3000,h1,"female");
            Employee emp2 = new Employee("sayeeeeeeed", 2,"developer",5000,h2,"female");
            Employee emp3 = new Employee("Atef", 3,"developer",12000,h2,"male");
            Employee emp4 = new Employee("omar", 4,"developer",3000,h2,"male");
            Employee emp5 = new Employee("maged", 5,"developer",3000,h2,"male");
            Employee emp6 = new Employee("mohamed",6,"developer",3000,h2,"male");

            Employee[] arrOfEmployees = { emp1, emp2,emp3 };

            //Employee[] arrOfEmployees2 = new Employee[10];
            Employee[] arrOfEmployees2 = new Employee[] { emp4, emp5, emp6 };
            
                
           


            //PrintArrayOfEmployees(arrOfEmployees);
            #endregion

            #region Q6 Menu
            //GetEmpById(1, arrOfEmployees);
            //GetEmpByName("ahmed", arrOfEmployees);
            //Console.WriteLine("the count is " + Count(arrOfEmployees2));
            //UpdateEmpById(1, arrOfEmployees);



            #endregion


            
            Department dept1 = new Department(1,"finance","ahmed",arrOfEmployees);
            Department dept2 = new Department(2,"Management","Atef",arrOfEmployees2);

            Department [] arrOfDepartments = { dept1, dept2 };
            
            Company Mycompany = new Company("my company",arrOfDepartments);

            //DisplayAllDepartments(arrOfDepartments);
            //DisplayEmpCountPerDept(Mycompany, 2)

            //DisplayTotalEmployees(Mycompany);
            //SearchEmpById(5, dept2);
            //UpdateEmpByID(2, dept1);
            DeleteEmpByID(2, dept1);
            menu2('f');
        }
    }
}