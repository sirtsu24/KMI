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

                 float i = KMI;

                 switch (i)
                 {
                     case float n when (n < 16):
                         Console.WriteLine("Tervisele ohtlik alakaal");
                         break;

                     case float n when (n > 16 && n < 18.5):
                         Console.WriteLine("Alakaal");
                         break;

                     case float n when (n > 18.6 && n < 25):
                         Console.WriteLine("Normaalkaal");
                         break;

                     case float n when (n > 25.1 && n < 30):
                         Console.WriteLine("Ülekaal");
                         break;

                     case float n when (n > 30.1 && n< 35):
                         Console.WriteLine("Rasvumine");
                         break;

                     case float n when (n > 35.1 && n<40):
                         Console.WriteLine("Tugev rasvumine");
                         break;

                     case float n when (n > 40.1):
                         Console.WriteLine("Tervisele ohtlik rasvumine");
                         break;
                 }
             }

           /* if (age < 20 || age > 60)
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

               
                if (KMI < 16)
                {
                    Console.WriteLine("Your KMI is {0}. Tervisele ohtlik alakaal", Math.Round(KMI, 1));
                }
                else if (KMI > 16 && KMI < 18.5)

                {
                    Console.WriteLine("Your KMI is {0}. Alakaal", Math.Round(KMI, 1));
                }
                else if (KMI > 18.6 && KMI < 25)
                {
                    Console.WriteLine("Your KMI is {0}. Normaalkaal", Math.Round(KMI, 1));
                }
                else if (KMI > 25.1 && KMI < 30)
                {
                    Console.WriteLine("Your KMI is {0}. Ülekaal", Math.Round(KMI, 1));

                }
                else if (KMI > 30.1 && KMI < 35)
                {
                    Console.WriteLine("Your KMI is {0}. Rasvumine", Math.Round(KMI, 1));
                }

                else if (KMI > 35.1 && KMI < 40)
                {
                    Console.WriteLine("Your KMI is {0}. Tugev rasvumine", Math.Round(KMI, 1));
                }
                else
                {
                    Console.WriteLine("Your KMI is {0}. Tervisele ohtlik rasvumine", Math.Round(KMI, 1));
                }
            }  */      
                         
                
                     
                    

            


             Console.ReadLine();

        }
    }
}
