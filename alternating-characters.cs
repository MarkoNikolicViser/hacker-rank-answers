
using System;

class Solution {

   static void Main(string[] args)
    {
        var testCaseCount = int.Parse(Console.ReadLine());
        //reads input and parses int
        for (var i = 0; i < testCaseCount; i++)
        {
            //creates a for loop with i counter variable
            var deletedLetter = 0;
            //sets deletedCharacter count
            var nextLetter = Console.Read();
            var lastLetter = nextLetter;

            nextChar = Console.Read();

            //special handling for hacker rank execution environment. 10 is ascii code of line              feed '\n'.
            //Hacker rank uses '\n' character for end of a test case and -1 for end of file                 which marks the end of last test case.

            while (nextLetter != 10 && nextLetter != -1)
            //while there is a line to read
            {
                if (nextLetter == lastLetter)
                //if nextLetter = lastLetter add one to our deleted character count
                    deletedLetter++;
                else
                    lastLetter = nextLetter;
                //move to next char

                nextLetter = Console.Read();

            }
            Console.WriteLine(deletedLetter);
        }
