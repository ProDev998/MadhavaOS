using System;

class MadhavaOS
{
    static void Main()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("       Madhava OS");
        Console.WriteLine("------------------------------");

        while (true)
        {
            Console.Write("command > ");
            string command = Console.ReadLine();

            if (command == "exit")
            {
                Console.WriteLine("Shutting down Madhava OS...");
                break;
            }
            else
            {
                // Handle the command
                HandleCommand(command);
            }
        }
    }

    static void HandleCommand(string command)
    {
        switch (command)
        {
            case "sin":
                Console.Write("Enter angle in degrees: ");
                double angle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Sin({angle}) = {Math.Sin(DegreesToRadians(angle))}");
                break;
            case "cos":
                Console.Write("Enter angle in degrees: ");
                angle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Cos({angle}) = {Math.Cos(DegreesToRadians(angle))}");
                break;
            case "tan":
                Console.Write("Enter angle in degrees: ");
                angle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Tan({angle}) = {Math.Tan(DegreesToRadians(angle))}");
                break;
            case "arcsin":
                Console.Write("Enter value: ");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Arcsin({value}) = {RadiansToDegrees(Math.Asin(value))}");
                break;
            case "arccos":
                Console.Write("Enter value: ");
                value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Arccos({value}) = {RadiansToDegrees(Math.Acos(value))}");
                break;
            case "arctan":
                Console.Write("Enter value: ");
                value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Arctan({value}) = {RadiansToDegrees(Math.Atan(value))}");
                break;
            case "arctan2":
                Console.Write("Enter y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Arctan2({y}, {x}) = {RadiansToDegrees(Math.Atan2(y, x))}");
                break;
            case "log":
                Console.Write("Enter value: ");
                value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Log({value}) = {Math.Log10(value)}");
                break;
            case "ln":
                Console.Write("Enter value: ");
                value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Ln({value}) = {Math.Log(value)}");
                break;
            case "exit":
                Console.WriteLine("Shutting down Madhava OS...");
                break;
            default:
                Console.WriteLine("Command not recognized. Please try again.");
                break;
        }
    }

    static double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }

    static double RadiansToDegrees(double radians)
    {
        return radians * (180 / Math.PI);
    }
}
