using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {//5)Check existaance of palidrome 
         // get the input text
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            // Convert to array of words and display words  
            String[] wordsarray = ToWordsArray(text);
            (int[], int) palidromeResult = palidromecheck(wordsarray);
            int NoOfPalidromeWords = palidromeResult.Item2;
            int[] indexesOfPalidrome = palidromeResult.Item1;
            Console.WriteLine("there are {0} palidrome", NoOfPalidromeWords + 1);
            for (int u = 0; u < indexesOfPalidrome.Length; u++)
            {
                Console.WriteLine("{0} is palidrome in sentence at {1} index", wordsarray[indexesOfPalidrome[u]], indexesOfPalidrome[u]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
       /* static (int[], int) palidromecheck(String[] wordsarray)
        {
            int couant = 0;
            int[] iss = new int[wordsarray.Length]; // indexes array
            for (int i = 0; i < wordsarray.Length; i++)
            {

               /* String[] reversed = new String[wordsarray.Length];
                reversed[i] = Convert.ToString(wordsarray[i].Reverse());
                if (reversed[i] == wordsarray[i])
                {
                    couant++;
                    iss[i] = i;

                }
            }
            return (iss, couant);
        }*/
        // Method to convert a text to array of words
        static String[] ToWordsArray(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        static
    {
}
