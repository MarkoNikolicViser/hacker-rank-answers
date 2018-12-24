using System;

class Solution
{

    static void Main(String[] args)

    {
        int i, p, f;
        //declare int variables
        string[] input = Console.ReadLine().Split(' ');
        //declare string array first line of input
        int n = Convert.ToInt32(input[0]);
        //first char of first line is the number of slots in our array
        int leftRotate = Convert.ToInt32(input[1]);
        //left rotate is the amount of times we move our slot order to the left
        string[] a_temp = Console.ReadLine().Split(' ');
        //a_temp is the second line of input as string array
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        //we parse the temporary array

        int[] temparray = new int[n];
        //we declare a temporary holder int array


        for(p = 0; p<n; p++)
        //we write a for loop setting an array pointer 'p' to 0
            {
            f = (p-leftRotate) %n;
            //algorithm that finds our new first number of the array after the left rotations

            if(f != 0)
            //if our new number isn't the default slot
                {
                f= (n+ f) %n;
                //then we have another algo to run against it
                }

            temparray[f] = a[p];
            //the new first slot of the temporary array should match the array pointer of our input array
            }


        for(i = 0; i< n; i++)
        //for loop to iterate through temporary array
            {
        Console.Write(temparray[i] + " " );
        //write new array to console
            }


    }
}
