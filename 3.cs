using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string StudentID { get; set; }

    public Student(string name, int age, string studentID)
    {
        Name = name;
        Age = age;
        StudentID = studentID;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\nStudent Info:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Student ID: {StudentID}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("John Doe", 20, "S12345");
        student.DisplayInfo();
    }
}