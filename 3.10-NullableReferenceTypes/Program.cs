using System;

namespace _3._10_NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string? nullableString = null;
            TestClass? myNullableClass = null;
            //Warning CS8600 Converting null literal or possible null value to non-nullable type
            TestClass myNonNullableClass = myNullableClass;
#nullable disable
            TestClass anotherNullableClass = null;
            //Warning CS8632 The annotation for nullable reference types should only be used in code within a '#nullable' annotations
            TestClass? badDefinition = null;
            //Warning CS8632 The annotation for nullable reference types should only be used in code within a '#nullable' annotations
            string? anotherNullableString = null;
#nullable restore
            DatabaseReader dr = new DatabaseReader();
            // If the value from GetIntFromDatabase() is null,
            // assign local variable to 100.
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();
            // Longhand notation not using ?? syntax.
            int? moreData = dr.GetIntFromDatabase();
            if (!moreData.HasValue)
            {
                moreData = 100;
            }
            Console.WriteLine("Value of moreData: {0}", moreData);
            //Null-coalescing assignment operator
            int? nullableInt = null;
            nullableInt ??= 12;
            nullableInt ??= 14;
            Console.WriteLine(nullableInt);
            TesterMethod(null);
        }
        static void TesterMethod(string[] args)
        {
            // We should check for null before accessing the array data!
            Console.WriteLine($"You sent me {args?.Length} arguments.");
        }
    }
    public class TestClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;
        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }
        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
}
