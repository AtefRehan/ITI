using System.Threading.Channels;
using Q2;

class Program
{
    private static HiringDate _empHireDate;

    static void Main()
    {

        Employee[] employees = new Employee[1];


        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Enter details for Employee {i + 1}:");

            employees[i] = ReadEmployeeData();
        }


        Array.Sort(employees, (e1, e2) => e1.HireDate.Year.CompareTo(e2.HireDate.Year));

        // Print the sorted array
        Console.WriteLine("\nSorted Employees Based on Hire Date:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }


    private static Employee ReadEmployeeData()
    {
        // Employee emp = new Employee(3)

        Console.Write("Enter Employee ID: ");
        int tempID;
        while (!int.TryParse(Console.ReadLine(), out tempID))
        {
            Console.WriteLine("Invalid input. Please enter a valid ID.");
        }

        // emp.Id = tempID;


        Console.Write("Enter Employee Salary: ");
        float tempSalary;
        while (!float.TryParse(Console.ReadLine(), out tempSalary))
        {
            Console.WriteLine("Invalid input. Please enter a valid salary.");
        }

        // emp.Salary = tempSalary;


        Console.Write("Enter Hiring Date (day month year): ");
        string[] hireDate = Console.ReadLine().Split(' ');
        int day = int.Parse(hireDate[0]);
        int month = int.Parse(hireDate[1]);
        int year = int.Parse(hireDate[2]);

        
        

        

        
        



        Console.Write("Enter Employee Gender (M/F): ");
        Gender tempGender;
        while (!Enum.TryParse(Console.ReadLine(), out tempGender) || 
               (tempGender != Gender.Male && tempGender != Gender.Female))
        {
            Console.WriteLine("Invalid input. Please enter M or F for gender.");
        }

        // emp.Gender = tempGender;
        Employee emp = new Employee(tempID, tempSalary, tempGender, new HiringDate(day, month, year));

        return emp;
    }


    // private static bool TryParseHiringDate(string input, out HiringDate HiringDate)
    // {
    //     HiringDate = new HiringDate();
    //
    //     string[] dateParts = input.Split(' ');
    //
    //     if (dateParts.Length != 3)
    //     {
    //         return false;
    //     }
    //     
    //
    //     return true;
    // }
}
        
