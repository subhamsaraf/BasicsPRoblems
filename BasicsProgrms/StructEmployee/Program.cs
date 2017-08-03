using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEmployee
{
    class Program
    {
        public struct EName
        {
            public string _ename;
            public BirthDetails _dob;

        }
       public struct BirthDetails
        {
            public int _day;
            public int _month;
            public int _year;
        }

        public static void Input(int length, EName[] eName)
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the name of the Employee");
                eName[i]._ename = Console.ReadLine();
                Console.WriteLine("Enter the day of birth of the Employee");
                eName[i]._dob._day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Month of birth of the Employee");
                eName[i]._dob._month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Year of birth of the Employee");
                eName[i]._dob._year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }


        public static void Display(int length, EName[] eName)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(eName[i]._ename);
                Console.WriteLine(eName[i]._dob._day + "/" + eName[i]._dob._month + "/" + eName[i]._dob._year);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("No of Fields:");
            int length = Convert.ToInt32(Console.ReadLine());
            EName[] eName = new EName[length];
            Input(length,eName);
            Display(length, eName);
            Console.ReadKey();
            
            
        }

        

    }

}