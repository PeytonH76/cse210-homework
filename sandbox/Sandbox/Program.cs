class Program {
    static void Main(string[] args) {

        var employees = new List<Employee>();

        var salary = new Employee();
        var hourly = new HourlyEmployee();
        Console.WriteLine(salary.CalculateYearlyPay());
        Console.WriteLine(hourly.CalculateYearlyPay());

        employees.Add(salary);
        employees.Add(hourly);

        foreach (var e in employees){
            e.CalculateYearlyPay();
        }
        
    }
}

class Employee{

    private int Salary = 100000;
    virtual public int CalculateYearlyPay(){
        return Salary;
    }
}

class HourlyEmployee: Employee{
    private int HourlyWage = 25;
    private int HoursPerYear = 2000;

    public override int CalculateYearlyPay()
    {
        return HourlyWage * HoursPerYear;
    }
}

// Method Overriding

// When a child class provides its own implementation of a method

abstract class Person {
    abstract public string Speak();
}

class NicePerson : Person
{
    public override string Speak()
    {
        return "Hello! How are you today. It's so nice outside.";
    }
}

class MeanPerson : Person
{
    public override string Speak()
    {
        return "Your code is the worst.";
    }
}