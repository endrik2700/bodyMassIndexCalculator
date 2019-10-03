using System;



class Program
{
    static void Main(string[] args)
    {
        string name;
        int age;
        Console.WriteLine("What's your name?");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name + " do you know c# sucks? Anyways, what's your age- type it below please?");
        age = int.Parse(Console.ReadLine());
        if (age >= 20 && age < 65)
        {
            CalculateBodyMass();
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You can not get right results as your age is not between 20-60 years. Therefore there will be no calculations, thank you!");
        }
        } 
    
    public static void CalculateBodyMass()
    {
        Console.WriteLine("What's your bodyweight in kg-s  -(use a point insetad of a comma) ?");
        Double bodyWeight = Double.Parse(Console.ReadLine());
        Console.WriteLine("What's your length in centimeters?");
        Double lengthSquare = Math.Pow(Double.Parse(Console.ReadLine()), 2);
        Double bodyMass = bodyWeight / lengthSquare;
        bodyMass = Math.Round(bodyMass * 10000, 2);
        Console.WriteLine(bodyMass);
        //Console.ReadLine();
        string suggestion;

        if (bodyMass < 16)
        {
            suggestion = "You are in severe underweight";
        }

        else if (bodyMass >= 16 && bodyMass < 18.6)
        {
            suggestion = "You are in underweight";
        }
        else if (bodyMass>= 18.6 && bodyMass <= 25)
        {
            suggestion = "You are in normal weight";
        }
        else if (bodyMass >= 25.1 && bodyMass <= 30)
        {
            suggestion = "You are in overweight";
            
        }

        else if (bodyMass>= 30.1 && bodyMass <= 35)
        {
            suggestion = "You are in obesity";
        }
        else if (bodyMass >= 35 && bodyMass <= 40)
        {
            suggestion = "You are in high obesity";
            
        }
        else
        {
            suggestion = "You are in dangerous to healt level of  obesity)";
        }
          Console.WriteLine (suggestion);
          Console.ReadLine();
          //return suggestion;
    }

  }
