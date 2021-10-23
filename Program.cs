using System;
using System.Collections.Generic;
using System.Text;

namespace Program2
{
    class Program
    {
        /*
         * Note: For all these exercises, ignore input validation unless otherwise specified. 
         * Assume the user provides input in the format that the program expects.
         */

        public static void Exercise1()
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen. 
             * Work out if the numbers are consecutive. 
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
             * display a message: "Consecutive"; otherwise, display "Not Consecutive".
             */

            string userInput;
            var myList = new List<int>();
            int convertNum;
            bool isTrue = true;
            

            Console.WriteLine("Please enter in a few numbers seperated by a hypen 1-2-3-4-5");
            userInput = Console.ReadLine();

            var UserStringIP = userInput.Split("-");

            foreach (var num in UserStringIP)
            {
                convertNum = Int32.Parse(num);

                myList.Add(convertNum);

                
            }

            

            myList.Sort();


            for (var i = 1; i < myList.Count; i++)
            {
                if (myList[i] - myList[i -1] != 1)
                {

                    isTrue = false;
                }
                else
                {
                    isTrue = true;
                }
               
            }

            if (isTrue)
            {
                Console.WriteLine("Consecutive \n");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

          
            

        }
        public static void Exercise2()
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen. 
             * If the user simply presses Enter, without supplying an input, 
             * exit immediately; otherwise, check to see if there are duplicates. 
             * If so, display "Duplicate" on the console.
             */

            string userInput;
            var myList = new List<int>();
            var myNewList = new List<int>();
            int convertToInt;
            bool isTrue = false;


            Console.WriteLine("Please enter in a few numbers seperated by a hypen. Ex: 1-2-3-4");
            userInput = Console.ReadLine();



            if (String.IsNullOrWhiteSpace(userInput))
            {
                return;

            }

            var userStringA = userInput.Split("-");

            foreach (var digit in userStringA)
            {
                convertToInt = Convert.ToInt32(digit);
                myList.Add(convertToInt);

            }


            foreach (var num in myList)
            {
                if (!myNewList.Contains(num))
                {
                    myNewList.Add(num);

                }
                else
                {
                    isTrue = true;
                }
            }

            if (isTrue)
            {
                Console.WriteLine("There is duplicates");

            }
            else
            {
                Console.WriteLine("There is no duplicates");
            }


        }


        

        public static void Exercise3()
        {
            /*
             * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
             * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
             * If the user doesn't provide any values, consider it as invalid time.
             */

            
            string userInput;
            int hour;
            int minutes;

            Console.WriteLine("User enter in a time value in 24 hour time (e.g. 19:00).");
            userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid time");
            }

            var userInputS = userInput.Split(":");

            if (userInputS.Length != 2)
            {
                Console.WriteLine("Invalid Time \n");
            }

            try
            {
                hour = Convert.ToInt32(userInputS[0]);
                minutes = Convert.ToInt32(userInputS[0]);

                if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
                {
                    Console.WriteLine("Okay \n");
                }
                else
                {
                    Console.WriteLine("Invalid Time \n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time \n");
            }


        }
        public static void Exercise4()
        {

            /*
             * Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. 
             * For example, if the user types: "number of students", display "NumberOfStudents". 
             * Make sure that the program is not dependent on the input. 
             * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
             */

            string userInput;
            var variableName = "";
            

            Console.WriteLine("Enter a few words separated by a space");
            userInput = Console.ReadLine();

          
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Error");
                return;
            }

            var userStringA = userInput.Split(" ");
           

            foreach (var word in userStringA)
            {


                var ans = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName = variableName + ans;
            }

            Console.WriteLine(variableName);
        }
        public static void Exercise5()
        {

            /*
             * Write a program and ask the user to enter an English word. 
             * Count the number of vowels (a, e, o, u, i) in the word.
             * So, if the user enters "inadequate", the program should display 6 on the console.
             */

            const char A = 'a';
            const char E = 'e';
            const char O = 'o';
            const char U = 'u';
            const char I = 'i';
            int counter = 0;

            string userInput;

            Console.WriteLine("Please enter a word! ");
            userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Error");
                return;
            }

            foreach (char chr in userInput.ToLower())
            {

                if (A == chr || E == chr || O == chr || U == chr || I == chr)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Total vowels in word '{userInput} contains: {counter} vowels.");



        }

        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();




        }
    }
}
