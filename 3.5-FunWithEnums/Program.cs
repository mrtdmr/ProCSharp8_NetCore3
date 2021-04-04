using System;

namespace _3._5_FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make an EmpTypeEnum variable.
            EmpTypeEnum emp = EmpTypeEnum.Contractor;
            AskForBonus(emp);
            Console.ReadLine();
            // Make a contractor type.
            EmpTypeEnum emp2 = EmpTypeEnum.Contractor;
            AskForBonus(emp2);
            // Print storage for the enum.
            Console.WriteLine("EmpTypeEnum uses a {0} for storage",
            Enum.GetUnderlyingType(emp2.GetType()));
            Console.ReadLine();
            // This time use typeof to extract a Type.
            Console.WriteLine("EmpTypeEnum uses a {0} for storage",
            Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
            // Prints out "emp is a Contractor".
            Console.WriteLine("emp2 is a {0}.", emp2.ToString());
            Console.ReadLine();
            EmpTypeEnum e2 = EmpTypeEnum.Contractor;
            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }
        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
        // This method will print out the details of any enum.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Get all name-value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
        // A custom enumeration.
        enum EmpTypeEnum
        {
            Manager, // = 0
            Grunt, // = 1
            Contractor, // = 2
            VicePresident // = 3
        }
        // Begin with 102.
        enum EmpTypeEnum2
        {
            Manager = 102,
            Grunt, // = 103
            Contractor, // = 104
            VicePresident // = 105
        }
        // Elements of an enumeration need not be sequential!
        enum EmpType3
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }
        // This time, EmpTypeEnum maps to an underlying byte.
        enum EmpTypeEnum4 : byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }
    }
}
