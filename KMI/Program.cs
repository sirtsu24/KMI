using System;

namespace KMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float height;
            float bodyweight;


            Console.WriteLine("Hello! What is yor name?");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}", name);

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            if (age < 20 || age > 60)
            {
                Console.WriteLine("Sorry but you can't use this program");
            }
            else
            { 
                Console.WriteLine("Please enter your height in meters:"); //use , not .
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your bodyweight in kilograms:"); // use , not .              
                bodyweight = float.Parse(Console.ReadLine());
                
                float KMI = bodyweight / (height * height);
                

                Console.WriteLine("Your KMI is {0}", Math.Round(KMI, 1));
            }
            
                                                
            Console.ReadLine();

        }
    }
}
