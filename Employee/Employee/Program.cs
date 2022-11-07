class Employee
{
    public string name; 
    public string surname; 
    public static string? dateOfHire; 
    public OperateCost operationCost;
    public Employee(string name, string surname, string dateOfHire, OperateCost opCost)
    {
        this.name = name;
        this.surname = surname;
        Employee.dateOfHire = dateOfHire;
        this.operationCost = opCost;

    }
    public static double DiscoverGrade(string dateOfHire)
    {
        double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

        if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
            return 1.1;
        else if (dateValueForGrade >= 3650)
            return 1.25;
        else
            return 1.5;
    }
}

public abstract class OperateCost
{
    public double salary;
    public double tax;

    public abstract void ApplyBonus(double bonus, double grade);
    public abstract void ApplyTax();
}

class Slave : OperateCost
{
    public override void ApplyBonus(double bonus, double grade)
    {
        salary = (1000 + 2 * bonus) * grade;
    }

    public override void ApplyTax()
    {
        tax = salary * 0.34;
    }
}
class вчитель : OperateCost
{
    public override void ApplyBonus(double bonus, double grade)
    {
        salary = (1000 + 5 * bonus) * grade;
    }
    public override void ApplyTax()
    {
        tax = salary * 0.34;
    }
}

class Lord : OperateCost
{
    public override void ApplyBonus(double bonus, double grade)
    {
        salary = (1000 + 10 * bonus) * grade;
    }
    public override void ApplyTax()
    {
        tax = salary * 0.34;
    }
}
class Program
{
    static void Main(string[] args)
    {
        OperateCost oc = new вчитель();
        Employee emp = new Employee("Володимр", "Пасів", "06.09.2019", oc);
        double grade = Employee.DiscoverGrade("06.09.2019");
        Console.WriteLine("Ім'я: {0}, прізвище: {1}, дата прийняття на роботу: {2}, посада: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
        oc.ApplyBonus(2500, grade);
        oc.ApplyTax();
        Console.WriteLine("Salary: {0}, Tax: {1}", emp.operationCost.salary, emp.operationCost.tax);
        Console.ReadKey();
    }
}