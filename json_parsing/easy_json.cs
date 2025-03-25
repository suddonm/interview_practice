using System.Text.Json;

public class EasyJSON
{
    public class Employee
    {
        public int id { get; set; }  
        public string name { get; set; }  
        public string department { get; set; }
        public int salary { get; set; }
    }

    List<Employee> employees;

    public EasyJSON()
    {
        employees = new List<Employee>();
    }

    public void LoadEmployees(string filepath)
    {
        using (StreamReader sr = new StreamReader(filepath))
        {
            string t = sr.ReadToEnd();
            employees = JsonSerializer.Deserialize<List<Employee>>(t);
        }
    }

    public void PrintEmployees()
    {
        foreach(var e in employees)
        {
            PrintEmployee(e);
        }
    }

    public void PrintEmployee(Employee e)
    {
        Console.Write(e.id + " - " + e.name + " - " + e.department + " - " + e.salary);
    }

    public void PrintHighestSalary()
    {
        PrintEmployee(employees.OrderByDescending(w => w.salary).First());
    }

    public void PrintAveragePerDepartment(string department)
    {
        Console.WriteLine(employees.Where(w => w.department.ToLower().Equals(department.ToLower())).Average(w => w.salary));
    }
}