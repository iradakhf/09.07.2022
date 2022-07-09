using System;
namespace arrays
{
    class Program
    {
        static void Main (string [] args)
        {
            int[] numb = { 1, 5, 68, 7, 9 };
            
            
                var resultArray =ReturnRangeOfNumbers(numb, 4);
            
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
            
            

        }
        public static int [] ReturnRangeOfNumbers(int[] numbers, int number)
        {  int[] result = new int [number];
            
            for (int i = 0; i < number ; i++)
            {

                result[i]=numbers[i];
                
            }
            
                return result;
            
            
            
        }
    }
}