using System;
using System.Collections.Generic;
// for .Add and List functionality
using System.Linq;
//for .Sum, .Take

class Solution {
    static void Main (String[] args){
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        //read first line of input, split into an array, convert to integer
        int n = arr[0];
        //n is the first number of the first line, representing the number of preliminary contests
        int k = arr[1];
        //k is the second number of the first line, representing the amount of contests Lena can lose
        List<int> importants = new List<int>();
        //instanstiate a list of important contests
        List<int> notImportants = new List<int>();
        //instantiate a list of not important contests
        for(int i = 0; i < n; i++)
        //for loop with variable i as counter
        {
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //take in the next lines, splitting them and converting them into integers
            if (arr1[1] == 1)
            //if the second number in the array is 1
                importants.Add(arr1[0]);
            //add the luck balance to the importants list
            else notImportants.Add(arr1[0]);
            //if not add it to the not importants list
        }
            importants = importants.OrderByDescending(num => num).ToList();
            //order the importants by descending
            Console.WriteLine(notImportants.Sum() + importants.Take(k).Sum() - importants.Skip(k).Sum());
            //write our output: the sum of the not importants added to the sum of the amount of important contests amount of contests lena can lose importants () and subtracting the importants that don't fall within the range of contests lena can lose
    }
}
