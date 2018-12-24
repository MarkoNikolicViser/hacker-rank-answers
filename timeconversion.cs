using System;

class Solution {
// declare solution class
 static void Main(String[] args) {
    //call main method
       string time = Console.ReadLine();
    //define a string variable time to read input
       int h = int.Parse(time.Substring(0,2));
    //defines an integer variable parsing the input, and running the substring method against the hour slots.
       string ampm = time.Substring(8,2);
//defines a string variable representing the AM or PM slot of the input.
       if(ampm == "AM"){
//test for 12 AM condition
           if (h == 12)
               h = 0;
//12AM is 0

           Console.Write("0" + h + ":" + time.Substring(3,5));
//writes 00 as hour and prints the rest of the time

       }else if(ampm == "PM"){
//test for PM condition
           if (h != 12)
               Console.Write((h+12) + ":" + time.Substring(3,5));
//converts 12 hour AMPM time to military time by adding 12 to PM times
           else
               Console.Write(h + ":" + time.Substring(3,5));
//writes for 12 PM
       }
   }
}
