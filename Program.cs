using System;


namespace IT_projects__dev_phase
{
    class Program
    {
        static void Main(string[] args)
        {  
            string name;
            int age;
            //double bodyMass;
            //double weight;
            //double length;
            Console.WriteLine("What's your name?");
            name =Console.ReadLine();
            Console.WriteLine("Hello " + name + " do you know c# sucks? Anyways, what's your age- type it below please?");
            age = int.Parse(Console.ReadLine());
            if (age >= 20 && age < 65)
            {
                
                Console.WriteLine(calculateBodyMass());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You can not get right results as your age is not between 20-60 years. Therefore there will be no calculations, thank you!");
            }


        }
        public static double calculateBodyMass () {
            Console.WriteLine ("What's your bodyweight in kg-s  -(use a point insetad of a comma) ?");
         double bodyWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your length in centimeters?");
         double lengthSquare = Math.Pow (double.Parse(Console.ReadLine()),2);
            double bodyMass = bodyWeight/lengthSquare;
            return bodyMass; 
        }
    }
}
