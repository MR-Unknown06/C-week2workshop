using System;
using System.Collections.Generic;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            Console.WriteLine("This is TODO 1");
            string userName = "Sita";
            Console.WriteLine($"userName: {userName}");

            // TODO 2: declare a variable called luckyNumber holding your favourite single-digit number.
            Console.WriteLine("\nThis is TODO 2");
            int luckyNumber = 7;
            Console.WriteLine($"luckyNumber: {luckyNumber}");

            // TODO 3: print ONE line that reads exactly: Hello, <your name>! Your lucky number is <the number>.
            Console.WriteLine("\nThis is TODO 3");
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants ----
            Console.WriteLine("\n--- Task 2: Constants ---");
            Circle circle = new Circle();
            Console.WriteLine($"PI = {Circle.PI}");
            Console.WriteLine($"Area (r=5)      = {circle.Area(5)}");
            Console.WriteLine($"Perimeter (r=5) = {circle.Perimeter(5)}");
            // Circle.PI = 3.15; // causes CS0131: The left-hand side of an assignment must be a variable, property or indexer

            // ---- Task 3: data types and type conversion ----
            byte tiny = 200;
            short small = 30000;

            // TODO 4: declare one variable for each of these types and give it a sensible value:
            //         int, long, float, double, decimal, char, bool
            Console.WriteLine("\nThis is TODO 4");
            int whole = 2000000000;
            long big = 9000000000L;
            float price = 3.14f;
            double precise = 3.14159265359;
            decimal money = 19.99m;
            char letter = 'A';
            bool isTrue = true;
            Console.WriteLine("Declared variables: int, long, float, double, decimal, char, bool");

            // TODO 5: convert the number 42 into a string, storing the result in a new variable.
            Console.WriteLine("\nThis is TODO 5");
            string numberAsText = 42.ToString();
            Console.WriteLine($"Converted 42 to string: \"{numberAsText}\"");

            // TODO 6: convert the string "3.14" into a double, storing the result in a new variable.
            Console.WriteLine("\nThis is TODO 6");
            double textAsNumber = double.Parse("3.14");
            Console.WriteLine($"Converted \"3.14\" to double: {textAsNumber}");

            // TODO 7: print one labelled line for each of the remaining variables, including the two you converted.
            Console.WriteLine("\nThis is TODO 7");
            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");
            Console.WriteLine($"int    = {whole} (type: int)");
            Console.WriteLine($"long   = {big} (type: long)");
            Console.WriteLine($"float  = {price}      (type: float)");
            Console.WriteLine($"double = {precise} (type: double)");
            Console.WriteLine($"decimal= {money}     (type: decimal)");
            Console.WriteLine($"char   = {letter}          (type: char)");
            Console.WriteLine($"bool   = {isTrue}       (type: bool)");
            Console.WriteLine($"string = {numberAsText}         (type: string, from 42.ToString())");
            Console.WriteLine($"double = {textAsNumber}      (type: double, from double.Parse(\"3.14\"))");

            // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };

            // TODO 8: print the numbers in their original order on one line, separated by commas.
            Console.WriteLine("\nThis is TODO 8");
            Console.WriteLine($"Original : {string.Join(", ", numbers)}");

            // TODO 9: sort them ascending with Array.Sort, then print the line again.
            Console.WriteLine("\nThis is TODO 9");
            Array.Sort(numbers);
            Console.WriteLine($"Sorted   : {string.Join(", ", numbers)}");

            // TODO 10: reverse them with Array.Reverse, then print again.
            Console.WriteLine("\nThis is TODO 10");
            Array.Reverse(numbers);
            Console.WriteLine($"Reversed : {string.Join(", ", numbers)}");

            // TODO 11: print each element on its own line using a for loop, showing the index as well as the value.
            Console.WriteLine("\nThis is TODO 11");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] = {numbers[i]}");
            }

            // TODO 12: use Array.IndexOf to find the position of 19 and print it. Then look up 100 and print that too.
            Console.WriteLine("\nThis is TODO 12");
            Console.WriteLine($"IndexOf(19)  = {Array.IndexOf(numbers, 19)}");
            Console.WriteLine($"IndexOf(100) = {Array.IndexOf(numbers, 100)}");

            // ---- Task 5: DateTime and TimeSpan ----
            DateTime birthDate = new DateTime(2004, 3, 15);

            // TODO 13: declare a DateTime holding the current date and time, called today.
            Console.WriteLine("\nThis is TODO 13");
            DateTime today = DateTime.Now;
            Console.WriteLine($"today: {today:yyyy-MM-dd HH:mm:ss}");

            // TODO 14: subtract birthDate from today. The result is a TimeSpan — name it ageSpan.
            Console.WriteLine("\nThis is TODO 14");
            TimeSpan ageSpan = today - birthDate;
            Console.WriteLine($"ageSpan: {(int)ageSpan.TotalDays} total days");

            // TODO 15: work out the age in whole years from the TimeSpan and store it in an int called years.
            Console.WriteLine("\nThis is TODO 15");
            int years = (int)(ageSpan.TotalDays / 365.25);
            Console.WriteLine($"Age in whole years: {years}");

            // TODO 16: print your birth date, today's date, your age in years, and your birth date plus 10 days.
            Console.WriteLine("\nThis is TODO 16");
            Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
            Console.WriteLine($"Total days : {(int)ageSpan.TotalDays}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----
            List<string> fruits = new() { "Apple", "Mango", "Banana" };

            // TODO 17: add one more fruit to the end of the list.
            Console.WriteLine("\nThis is TODO 17");
            fruits.Add("Orange");
            Console.WriteLine("Added 'Orange' to fruits list");

            // TODO 18: remove one fruit from the list.
            Console.WriteLine("\nThis is TODO 18");
            fruits.Remove("Mango");
            Console.WriteLine("Removed 'Mango' from fruits list");

            // TODO 19: print every remaining fruit on its own line using a foreach loop.
            Console.WriteLine("\nThis is TODO 19");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  {fruit}");
            }

            // TODO 20: declare a Dictionary<int, string> called byId whose keys are 1, 2 and 3 and whose values are fruit names.
            Console.WriteLine("\nThis is TODO 20");
            Dictionary<int, string> byId = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" }
            };
            Console.WriteLine("Declared byId dictionary with 3 entries");

            // TODO 21: add a fourth entry, then print every key-value pair using a foreach loop over the dictionary.
            Console.WriteLine("\nThis is TODO 21");
            byId.Add(4, "Orange");
            foreach (KeyValuePair<int, string> pair in byId)
            {
                Console.WriteLine($"  {pair.Key} -> {pair.Value}");
            }
        }
    }
}
