// Abstraction: Base class defines abstract methods
//Encapsulation: Attributes are private or protected.
//Inheritance: All activities share _date and _minutes.
//Polymorphism: GetDistance(), GetSpeed(), and GetPace() are overridden in derived classes to provide specific calculations.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        activities.Add(new Cycling(new DateTime(2026, 11, 03), 45, 15.0));
        activities.Add(new Running(new DateTime(2025, 11, 04), 30, 3.0));
        activities.Add(new Swimming(new DateTime(2024, 11, 05), 20, 20));

        // Iterate and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}