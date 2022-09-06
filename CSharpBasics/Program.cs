using System;
using System.Globalization;

namespace CSharpBasics
{
    internal class Program
    {
        // when the start button is pressed, C# goes into the program
        // looking for the main function and then executes it
        static void Main()
        {
            // #1 THE VERY BASICS
            // console.log
            Console.WriteLine("Hello world!");
            // keep the console open (waiting for you to press 'Enter' to continue or close)
            Console.ReadLine();

            // #2 VARIABLES
            // declaration + assignation
            string characterName = "Thomas"; // note that 'var characterName = "Thomas";' is equivalent (implicitly typed)
            // declaration
            int characterAge;
            // assignation
            characterAge = 28;
            // concatenation
            Console.WriteLine(characterName + " is " + characterAge + " years old.");
            // several declaration at once;
            string color, pluralNoun, celebrity;
            color = "blue";
            pluralNoun = "cats";
            celebrity = "snoop dogg";
            Console.WriteLine(color);
            Console.WriteLine(pluralNoun);
            Console.WriteLine(celebrity);
            // nullable types
            int? nullableInt = null;
            Nullable<int> nullableInt1 = null;
            Console.WriteLine(nullableInt);
            Console.WriteLine(nullableInt1);
            Console.ReadLine();

            // #3 DATA TYPES
            // STRING-LIKE
            string randomString = "random string";
            char randomTestGrade = 'A';

            // NUMBER-LIKE
            int randomInt = 10;
            // least precise type (up to 6 to 9 decimal digits) --The literal with the f or F suffix is of type float
            float randomFloat = 1.0F; // note that '.0' is needed
            // average precision type (up to 15 to 17 digits) --The literal without suffix or with the d or D suffix is of type double
            double randomDouble = 0.5;
            // most precise type (up to 28 - 29 digits) --The literal with the m or M suffix is of type decimal
            decimal randomDecimal = 0.5M;

            // BOOLEANS
            bool randomBool = false;

            //output
            Console.WriteLine(
                randomString + " " +
                randomTestGrade + " " +
                randomInt + " " +
                randomFloat + " " +
                randomDouble + " " +
                randomDecimal + " " +
                randomBool);
            Console.ReadLine();

            // #3.1 STRINGS
            // special chars
            string specialCharsExample = "Hello\nworld\n!";
            string anotherSpecialCharsExample = "they said \"learn more\"";
            
            // concatenation
            // see #2 VARIABLES section

            // strings attributes
            int stringLength = anotherSpecialCharsExample.Length;
            Console.WriteLine(stringLength);

            // strings methods
            // upercase
            Console.WriteLine(specialCharsExample.ToUpper());
            // lowercase
            Console.WriteLine(specialCharsExample.ToLower());
            // contains
            Console.WriteLine(specialCharsExample.Contains("Hello"));
            // figure out what's the first character
            Console.WriteLine(specialCharsExample[0]);
            // get index of a char or word
            Console.WriteLine(specialCharsExample.IndexOf("o")); // return at which index the first 'o' is encountered
            Console.WriteLine(specialCharsExample.IndexOf("z")); // return -1 as there is no 'z' in this string
            Console.WriteLine(specialCharsExample.IndexOf("world")); // return at which index the word 'world' starts
            // substring (sub a a part of the string)
            Console.WriteLine(specialCharsExample.Substring(6)); // print only 'world\n!'
            Console.WriteLine(specialCharsExample.Substring(6, 5)); // print only 'world' as we specified a lenght of 5

            // #3.2 NUMBERS
            // numbers operations
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(8 / 4);
            Console.WriteLine(5 % 2);
            Console.WriteLine((4 + 2) * 3);
            // be careful by doing this : it returns a decimal number (type is different)
            Console.WriteLine(5 + 8.1);

            // numbers incrementation
            int aFreshNewNumber = 1;
            Console.WriteLine(aFreshNewNumber++); // it returns the old value and store the new one into variable : var = 2, returns 1
            Console.WriteLine(aFreshNewNumber--); // var = 1, returns 2 (you could use --var to returns the new value instead the old one)
            Console.WriteLine(aFreshNewNumber += 2); // var = 3, returns 3
            Console.WriteLine(Math.Abs(-40)); // returns 40
            Console.WriteLine(Math.Pow(2, 3)); // returns 8
            Console.WriteLine(Math.Sqrt(36)); // returns 6
            Console.WriteLine(Math.Max(4, 90)); // returns the biggest
            Console.WriteLine(Math.Min(4, 90)); // returns the smallest
            Console.WriteLine(Math.Round(4.3)); // returns 4
            Console.WriteLine(Math.Round(4.6)); // returns 5

            // #3.3 ARRAYS
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            luckyNumbers[0] = 7;
            Console.WriteLine(luckyNumbers);
            // empty array
            string[] emptyArray1 = {};
            string[] emptyArray2 = new string[] {};
            string[] emptyArray3 = new string[0]; // 0 = array length
            // /!\ emptyArray2[1] = "hello" won't work as it is supposed to have a length of 0
            Console.WriteLine(emptyArray1);
            Console.WriteLine(emptyArray2);
            Console.WriteLine(emptyArray3);

            // #3.4 2D ARRAYS (MATRIX)
            int[,] numberGrid = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };
            Console.WriteLine(numberGrid[0,0]); // return 1

            int[,] numberGrid2 = new int[2, 3]; // 2 rows & 3 columns
            Console.WriteLine(numberGrid2);

            // #3.5 ARRAY OF ARRAYS
            int[][] jaggedArray =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            int[][] jaggedArray1 = new int[3][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Console.WriteLine(jaggedArray[0][0]); // return 1
            Console.WriteLine(jaggedArray1[2][2]); // return 9

            // #4 GET INPUT FROM USER
            Console.WriteLine("\nHello,\nWhat's your name?\n");
            string userName = Console.ReadLine();
            Console.WriteLine("So your name is " + userName + "\n");

            // #5 TYPE CONVERSION
            // from string to int
            Console.WriteLine(Convert.ToInt32("45"));
            // from string to double (to prevent the case of a user entering a decimal number)
            Console.WriteLine(
                Convert.ToDouble(
                    "27.8", CultureInfo.InvariantCulture
                    ) // otherwise -as my system is in French- it will assume I write decimals with a comma and will throw an error
                );

            // #6 METHODS
            // * check for the other #6 outside the main method
            Print("Hello boys & girls !");
            int myCubedNumber = Cube(2);
            Console.WriteLine(
                Convert.ToString(myCubedNumber)
                );

            // #7 IF STATEMENTS
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Print("You are male and tall");
            } else if (isMale)
            {
                Print("You are male and short");
            } else if (isTall)
            {
                Print("You are female and tall");
            } else
            {
                Print("You are female and short");
            }

            if (isMale || isTall)
            {
                Print("You are male or tall");
            } else
            {
                Print("You are neither male nor tall");
            }

            if (!isTall)
            {
                Print("You are not tall");
            }

            // **
            Print(Convert.ToString(GetMax(22, 35)));

            // #8 SWITCH STATEMENTS
            int dayNum = 0;
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "";
                    break;
            }

            Print(dayName);

            // #9 (DO) WHILE LOOPS
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int anotherIndex = 6;
            do
            {
                Console.WriteLine(anotherIndex);
                anotherIndex++;
            } while (anotherIndex <= 5); // execute the do block before checking the while and potientally loop through the do block

            // #10 FOR LOOPS
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            int baseNum = 2;
            int powNum = 5;
            int result = 1;
            for (int i = 0; i < powNum; i++) result *= baseNum; // and we created a GetPow loop (work only for positive powNum)

            // #10.1 FOREACH LOOPS
            int[] someNumbers = { 99, 98, 97, 96, 95, 94, 93, 92, 91, 90 };
            foreach (int number in someNumbers) Console.WriteLine(number);

            // #11 EXCEPTIONS HANDLING
            try
            {
                Console.WriteLine("Everything is alright!");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }

            try
            {
                Console.WriteLine("Everything is alright!");
            }
            catch (DivideByZeroException e) // now it only catches DivideByZero exceptions and nothing else
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
            catch (FormatException e) // as you can see it is possible to chain catch blocks to handle everything you need
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
            finally
            {
                Console.WriteLine("I'm executed no matter what (error or not)");
            }

            // #12 CLASSES & OBJECTS (see Book.cs, Student.cs and Movie.cs)

            //Book book1 = new Book();
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            //Book book2 = new Book
            //{
            //    title = "Lord of the Rings",
            //    author = "Tolkien",
            //    pages = 700
            //};

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
            Book book3 = new Book();

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
            Console.WriteLine(book3.title);

            Student student1 = new Student("Arthur", "Business", 2.8);
            Student student2 = new Student("John", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
        // #6 METHODS *
        static void Print(string message) // as usual 'static' means we can call the method without instanciating an object from this class 
        {
            Console.WriteLine(message);
        }

        static int Cube(int number)
        {
            return number * number * number;
        }

        // #7 IF STATEMENTS **
        static int? GetMax(int num1, int num2)
        {
            int? result;
            if (num1 > num2) result = num1;
            else if (num1 < num2) result = num2;
            else result = null;
            return result;
        }
    }
}
