using System;

class Program
{
    static void Main(string[] args)
    {
        // Enhancement: Added a reflection quote at the end to inspire the user and provide a thoughtful close to the activity
        int userInput = 0;
        
        while (userInput != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput == 1)
                {
                    Console.Clear();
                    BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity is designed to help you relax by guiding you through slow, controlled breathing. As you follow each breath, allow your mind to clear and focus your attention fully on your breathing.", 30);
                    activity1.Run();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity is designed to help you reflect on moments in your life when you demonstrated strength and resilience. Through this reflection, you will gain a deeper awareness of your inner capabilities and how you can apply them to other areas of your life.", 30);
                    activity2.Run();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity is designed to help you focus on the positive aspects of your life by encouraging you to list as many meaningful items as you can within a specific area.", 30);
                    activity3.Run();
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}