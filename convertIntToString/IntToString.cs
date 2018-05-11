using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertIntToString
{
    public class IntToString
    {
        static string[] ones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        static string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] hundreds = { "Hundred", "Thousand", "Million" };
        static int numberInput = 0;
        static string finalNumber;

        static void Main()
        {
            bool checkTrue = false; 

            Console.Write("Enter any number up to a Million's place: ");
            while (checkTrue == false){
                try
                {
                    numberInput = Convert.ToInt32(Console.ReadLine());
                    checkTrue = true;
                }
                catch 
                {
                    Console.WriteLine("Exception Caught, reloading question..");
                    Console.Write("Enter a Number: ");
                    checkTrue = false;
                }
            }

            int[] output = listifyNumber(numberInput);
            
           
            finalNumber = checkHundreds(output) + " " + checkRest(output);
            Console.WriteLine(finalNumber);
            Console.WriteLine("type anything to leave..");
            Console.ReadKey();
            
        }

        static public int[] listifyNumber(int number)
        {
            string numLength = Convert.ToString(number);
            int[] input = new int[numLength.Length]; // must set bounds of an array as apparent you cannot add more later
            for (int x = 0; x < numLength.Length; x++)
            {  // runs through the lengh of the input number
                input[x] = Convert.ToInt32(numLength[x].ToString()); // must convert char to string before turning into an int
            }
            Console.Write("New Array: ");  // displaying the new array before converting to words
            for (int x = 0; x < numLength.Length; x++)
            {
                Console.Write(input[x] + ", ");
            }
            return input;
        }

        static public string getFirstNumber(int[] output)
        {
            Console.WriteLine(ones[output[0] - 1]);
            return ones[output[0] - 1]; // prints out the first 
        }
        static public string checkHundreds(int[] output)
        {
            var strInput = numberInput.ToString();
            if (strInput.Length >= 3)
            {
                return getFirstNumber(output) + " Hundred";
            }
            else
            {
                return getFirstNumber(output);
            }
            
        }
        static public string checkRest(int[] output)
        {
            if (output[1] > 1) //checks the second digit to see if it's in the teens
            {
                // not a teen
            }
            else
            {
                //return a teen
            }
            return tens[output[1] - 2];
            
        }

    }
}
