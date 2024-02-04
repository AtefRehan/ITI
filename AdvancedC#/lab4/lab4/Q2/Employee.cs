using Q2;
public enum Gender
{
    Male=1,
    Female=2
}

public class Employee
{


    public int Id { get; set; }
    public float Salary { get; set; }
    public HiringDate HireDate { get; set; }
    public Gender Gender { get; set; }
    
    public Employee(int id, float salary, Gender gender ,HiringDate hireDate)
    {
        Id = id;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }

    
    private string DisplaySalary()
    {
        return String.Format("{0:C}", Salary);
    }


    public override string ToString()
    {
        return String.Format("ID: {0}, Salary: {1}, HireDate: {2}, Gender: {3}",
            Id, DisplaySalary(), HireDate, Gender);    }

    private static Gender ParseGender(string gender)
    {
        if (Enum.TryParse(gender, out Gender result) && (result == Gender.Male || result == Gender.Female))
        {
            return result;
        }
        throw new ArgumentException("Invalid gender value. Please provide 'M' or 'F'.");
    }
}