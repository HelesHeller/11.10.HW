using System;

class Program
{
    static void Main(string[] args)
    {
        // Завдання 3: створення музичних інструментів
        MusicalInstrument violin = new Violin("Скрипка", "Дерево", "Струнний");
        MusicalInstrument trombone = new Trombone("Тромбон", "Метал", "Духовий");
        MusicalInstrument ukulele = new Ukulele("Укулеле", "Дерево", "Струнний");
        MusicalInstrument cello = new Cello("Віолончель", "Дерево", "Струнний");

        // Звучання музичних інструментів
        violin.Sound();
        trombone.Sound();
        ukulele.Sound();
        cello.Sound();

        // Завдання 4: створення працівників
        Worker president = new President("Президент", 1, "Стратегічне керівництво");
        Worker security = new Security("Охоронець", 2, "Безпека об'єкта");
        Worker manager = new Manager("Менеджер", 3, "Управління персоналом");
        Worker engineer = new Engineer("Інженер", 4, "Проектування систем");

        // Вивід інформації про працівників
        president.Print();
        security.Print();
        manager.Print();
        engineer.Print();
    }
}

// Завдання 3: базовий клас "Музичний інструмент"
abstract class MusicalInstrument
{
    protected string Name { get; }
    protected string Material { get; }
    protected string Type { get; }

    public MusicalInstrument(string name, string material, string type)
    {
        Name = name;
        Material = material;
        Type = type;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Звучить {Name}");
    }
}

// Похідні класи для музичних інструментів
class Violin : MusicalInstrument
{
    public Violin(string name, string material, string type) : base(name, material, type) { }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Це скрипка, яка грає чудово!");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string material, string type) : base(name, material, type) { }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Це тромбон, який видає потужний звук.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string material, string type) : base(name, material, type) { }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Це укулеле, яке звучить яскраво.");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string material, string type) : base(name, material, type) { }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Це віолончель, яка має глибокий звук.");
    }
}

// Завдання 4: базовий абстрактний клас "Працівник"
abstract class Worker
{
    protected string Name { get; }
    protected int Id { get; }
    protected string Department { get; }

    public Worker(string name, int id, string department)
    {
        Name = name;
        Id = id;
        Department = department;
    }

    public abstract void Print();
}

// Похідні класи для працівників
class President : Worker
{
    public President(string name, int id, string department) : base(name, id, department) { }

    public override void Print()
    {
        Console.WriteLine($"Президент: {Name}, ID: {Id}, Відділ: {Department}");
    }
}

class Security : Worker
{
    public Security(string name, int id, string department) : base(name, id, department) { }

    public override void Print()
    {
        Console.WriteLine($"Охоронець: {Name}, ID: {Id}, Відділ: {Department}");
    }
}

class Manager : Worker
{
    public Manager(string name, int id, string department) : base(name, id, department) { }

    public override void Print()
    {
        Console.WriteLine($"Менеджер: {Name}, ID: {Id}, Відділ: {Department}");
    }
}

class Engineer : Worker
{
    public Engineer(string name, int id, string department) : base(name, id, department) { }

    public override void Print()
    {
        Console.WriteLine($"Інженер: {Name}, ID: {Id}, Відділ: {Department}");
    }
}
