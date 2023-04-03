using System;

namespace NewMathApp
{
    public class Utils
    {
        
        public static float[] GetNumericArrayFromUserInput()
        {
            while (true)
            {
                Console.Write("Please input a number array : ");
                string input = Console.ReadLine();

                string[] inputArray = input.Split(',');
                bool hasNonNumericValue = false;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (!float.TryParse(inputArray[i], out _))
                    {
                        hasNonNumericValue = true;
                        Console.WriteLine("Please input numbers only like ( [-3,2.4,1,0,-2.3] )");
                        break;
                    }
                }

                if (hasNonNumericValue)
                {
                    continue;
                }

                float[] numericArray = Array.ConvertAll(inputArray, float.Parse);
                return numericArray;
            }
        }
        

    }
}