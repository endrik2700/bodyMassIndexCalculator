using System;


namespace IT_projects__dev_phase
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            //double bodyMass  = calculateBodyMass();
            //int intBodyMass = int.Parse(calculateBodyMass().ToString()); 
             
            //double weight;
            //double length;
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " do you know c# sucks? Anyways, what's your age- type it below please?");
            age = int.Parse(Console.ReadLine());
            if (age >= 20 && age < 65)
            {

                Console.WriteLine(CalculateBodyMass());
                Console.ReadLine();
                Console.WriteLine(BodyMassSuggestions(CalculateBodyMass()));
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("You can not get right results as your age is not between 20-60 years. Therefore there will be no calculations, thank you!");
            }
            

        }
          public static string BodyMassSuggestions (double num) {
            string suggestion;

            if (CalculateBodyMass()<16) {

                suggestion = "You are in severe underweight)";
                return suggestion;
            }

            else if (CalculateBodyMass() >= 16 && CalculateBodyMass()<18.6) {
                suggestion = "You are in underweight)";
                return suggestion;
            }
            else if (CalculateBodyMass() >= 18.6 && CalculateBodyMass() <=25)
            {
                suggestion = "You are in normal weight)";
                return suggestion;
            }
            else if (CalculateBodyMass() >= 25.1 && CalculateBodyMass() <= 30)
            {
                suggestion = "You are in overweight)";
                return suggestion;
            }

            else if (CalculateBodyMass() >= 30.1 && CalculateBodyMass() <=35)
            {
                suggestion = "You are in obesity)";
                return suggestion;
            }
            else if (CalculateBodyMass() >= 35 && CalculateBodyMass() <= 40)
            {
                suggestion = "You are in high obesity)";
                return suggestion;
            }
            else
            {
                suggestion = "You are in dangerous to healt level of  obesity)";
                return suggestion;
            }

            //return suggestion;
        }



        public static Double CalculateBodyMass()
        {
            Console.WriteLine("What's your bodyweight in kg-s  -(use a point insetad of a comma) ?");
            Double bodyWeight = Double.Parse(Console.ReadLine());
            Console.WriteLine("What's your length in centimeters?");
            Double lengthSquare = Math.Pow(Double.Parse(Console.ReadLine()), 2);
            Double bodyMass = bodyWeight / lengthSquare;
            return bodyMass;
        }
    }
}
