using System;
class Employee{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int id, double salary){
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Salary: {Salary}");
    }
}
class Manager : Employee{
    public int TeamSize { get; set; }
    public Manager(string name, int id,double salary,int teamsize) : base(name, id, salary){
        TeamSize = teamsize;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}\n");
    }
}
class Developer : Employee{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, int id, double salary, string programminglanguage) : base(name, id, salary){
        ProgrammingLanguage = programminglanguage;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}\n");
    }
}
class Intern : Employee{
    public string InternshipDuration { get; set; }
    public Intern(string name, int id, double salary, string internshipduration) : base(name, id, salary){
        InternshipDuration = internshipduration;
    }
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {InternshipDuration}\n");
    }
}
class Program{
    static void Main(string[] args) {
        Manager mng = new Manager("Karan", 101, 50000, 10);
        Developer dev = new Developer("Rahul", 102, 40000, "C#");
        Intern intern = new Intern("Prakhar", 103, 20000, "6 months");
        mng.DisplayDetails();
        dev.DisplayDetails();
        intern.DisplayDetails();
    }
}
