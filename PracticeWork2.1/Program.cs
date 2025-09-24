using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Віртуальні методи
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} щось робить.");
    }
}

class Worker : Person
{
    public Worker(string name, int age) : base(name, age) { }

    // Перевизначення віртуальних методів
    public override void ShowInfo()
    {
        Console.WriteLine($"Робітник {Name}, Вік: {Age}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} виконує фізичну роботу.");
    }

    // 1 метод: передати посаду і зарплату
    public void SetJobInfo(string position, double salary)
    {
        Console.WriteLine($"Посада: {position}, Зарплата: {salary} грн");
    }

    // 2 метод: середня зарплата за 6 місяців
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

    // Перевизначення віртуальних методів
    public override void ShowInfo()
    {
        Console.WriteLine($"Інженер {Name}, Вік: {Age}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} проектує та планує.");
    }

    // Метод без параметрів
    public void ShowEngineerDetails()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Посада: Інженер, Зарплата: {Salary} грн, Стаж: {Experience} років");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об’єкт Робітника
        Worker w = new Worker("Іван", 35);
        w.ShowInfo();        // віртуальний метод
        w.Work();            // віртуальний метод
        w.SetJobInfo("Токар", 12000); // свій метод

        double avgSalary = w.AverageSalary(); // середня зарплата
        Console.WriteLine($"Середня зарплата за 6 місяців: {avgSalary} грн");

        Console.WriteLine();

        // Створюємо об’єкт Інженера
        Engineer e = new Engineer("Петро", 40, 20000, 15);
        e.ShowInfo();        // віртуальний метод
        e.Work();            // віртуальний метод
        e.ShowEngineerDetails(); // метод без параметрів

        Console.ReadLine();
    }
}
