using System;

namespace GIATRITRONGMANG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};

            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();

            bool checkName=false;


            for (int i=0; i <= students.Length;i++)
            {
                if (students[i].Equals(name))
                {
                    Console.WriteLine("Position of the students in the list " + name + " is: " + (i + 1));
                    break;
                }
                if (checkName=false)
                {
                    Console.WriteLine("Name not exist");
                }
                
            }
            
        }
    }
}
