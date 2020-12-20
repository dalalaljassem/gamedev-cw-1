using System;

namespace CW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "DJ";
            int age = 22;
            float speed = 350.5f;
            string superPower1 = "Laser Vision"; 
            string superPower2 = "telepathy";
            
            Console.WriteLine("My name is {0} and my super powers are {1} and {2}. I am {3} years old, and my speed is {4}", characterName, superPower1, superPower2,age,speed);
        }
    }
}
