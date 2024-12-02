using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
   
        Dictionary<string, string> phoneLookup = new Dictionary<string, string>();

        phoneLookup.Add("John", "123-456-7890");
        phoneLookup.Add("Jane", "234-567-8901");
        phoneLookup.Add("Joe", "345-678-9012");
        phoneLookup.Add("Jill", "456-789-0123");

        Console.WriteLine("Phone Book:");
        foreach (var item in phoneLookup)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine("1.Add phone number");
        Console.WriteLine("2.Delete phone number");
        Console.WriteLine("3.Find phone number");
        Console.WriteLine("4.Exit");
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        string name;
        string phoneNumber;


        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a name to add:");
                 name = Console.ReadLine();
                Console.WriteLine("Enter a phone number:");
                phoneNumber = Console.ReadLine();
                phoneLookup.Add(name, phoneNumber);
                break;
            case 2:
                Console.WriteLine("Enter a name to delete:");
                name = Console.ReadLine();
                if (phoneLookup.ContainsKey(name))
                {
                    phoneLookup.Remove(name);
                    Console.WriteLine($"{name} removed.");
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }
                break;
            case 3:
                Console.WriteLine("Enter a name to find:");
                name = Console.ReadLine();
                if (phoneLookup.ContainsKey(name))
                {
                    Console.WriteLine($"{name}: {phoneLookup[name]}");
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine("Phone Book:");
        foreach (var item in phoneLookup)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

       
    }
}