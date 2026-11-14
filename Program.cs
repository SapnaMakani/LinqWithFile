
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

// Create employee list
List<Employee> employees = new List<Employee>
{
    new Employee("Sapna", 92),
    new Employee("Revathi", 85),
    new Employee("Lana", 68),
    new Employee("Twinkal", 78),
    new Employee("Mo", 95),
    new Employee("Mariyam", 72),
    new Employee("olha", 88),
    new Employee("James", 60),
    new Employee("Olivia", 81),
};

// Filter employees and get the top 3
List<string> topEmployees = employees
    .Where(e => e.Score >= 75)
    .OrderByDescending(e => e.Score)
    .Take(3)
    .Select(e => $"{e.Name} — {e.Score}")
    .ToList();

// Save the results to a file
File.WriteAllLines("report.txt", topEmployees);

Console.WriteLine("Report created.");

// Read the file and display the results
string[] report = File.ReadAllLines("report.txt");

Console.WriteLine("\nTop 3 employees:");

foreach (string line in report)
{
    Console.WriteLine(line);
}

// Employee record
public record Employee(string Name, int Score);
