using System;

// Абстрактний клас Person
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Абстрактні методи
    public abstract void ShowInfo();
    public abstract void Work();
}

class Worker : Person
{
    public Worker(string name, int age) : base(name, age) { }

    public override void ShowInfo()
    {
        Console.WriteLine($"Робітник {Name}, Вік: {Age}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} виконує фізичну роботу.");
    }

    public void SetJobInfo(string position, double salary)
    {
        Console.WriteLine($"Посада: {position}, Зарплата: {salary} грн");
    }

    public double AverageSalary()
    {
        double[] salaries = { 10000, 11000, 12000, 11500, 10500, 12500 };
        double sum = 0;
        for (int i = 0; i < salaries.Length; i++)
        {
            sum += salaries[i];
        }
        double avg = sum / salaries.Length;
        return avg;
    }

    public override string ToString()
    {
        return $"Worker: {Name}, {Age}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Worker other)
            return Name == other.Name && Age == other.Age;
        return false;
    }
}

class Engineer : Person
{
    public double Salary { get; set; }
    public int Experience { get; set; }

    public Engineer(string name, int age, double salary, int experience)
        : base(name, age)
    {
        Salary = salary;
        Experience = experience;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Інженер {Name}, Вік: {Age}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} проектує та планує.");
    }

    public void ShowEngineerDetails()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Посада: Інженер, Зарплата: {Salary} грн, Стаж: {Experience} років");
    }

    public override string ToString()
    {
        return $"Engineer: {Name}, {Age}, {Salary}, {Experience}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Engineer other)
            return Name == other.Name && Age == other.Age && Salary == other.Salary && Experience == other.Experience;
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker w = new Worker("Іван", 35);
        w.ShowInfo();
        w.Work();
        w.SetJobInfo("Токар", 12000);
        double avgSalary = w.AverageSalary();
        Console.WriteLine($"Середня зарплата за 6 місяців: {avgSalary} грн");
        Console.WriteLine(w.ToString());
        Console.WriteLine($"Equals (з собою): {w.Equals(w)}");

        Console.WriteLine();

        Engineer e = new Engineer("Петро", 40, 20000, 15);
        e.ShowInfo();
        e.Work();
        e.ShowEngineerDetails();
        Console.WriteLine(e.ToString());
        Console.WriteLine($"Equals (з собою): {e.Equals(e)}");

        Console.ReadLine();
    }
}
