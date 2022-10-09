//Adnan bolifa
//Learing algorithms in C# 
//Maybe making some cool projects in the future.
using System;
namespace Learnging
{
    class Program
    {
        public static void Main()
        {
            //Main
            Names names = new Names();
            List<String> classes = names.b8;
            ClassSelector classSelector = new ClassSelector(classes, classes.Count);
            classSelector.print();
            Console.ReadLine();

            
        }
    }
}