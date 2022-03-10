 using System;

namespace mustafatask2
{
    public class program
    {
         static void Main(string[] args)
         {
            int[] arr = { 12, 45, 5, 25, 36 };

            int maxnumber = arr[0];

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > maxnumber)
                {
                    maxnumber = arr[i];
                }
            }
             Console.WriteLine(maxnumber);
         }


    }
        
    
}
