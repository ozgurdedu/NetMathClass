using System;

namespace NewMathApp
{
    public class NewMath
    {
        public static void Min(float a, float b)
                {
                    var isEqual = (a == b);
                    if (!isEqual)
                    {
                        var minValue = (a < b) ? a : b; 
                        Console.WriteLine("\n MINIMUM VALUE is : " + minValue + "\n");
                    }
                    else 
                        Console.WriteLine("Same values");
                }

                public static void Max(float a, float b)
                {
                    var isEqual = (a == b);
                    if (!isEqual)
                    {
                        var maxValue = (a > b) ? a : b; 
                        Console.WriteLine("\n MAXIMUM VALUE is : " + maxValue + "\n");
                    }
                    else 
                        Console.WriteLine("Same values");
                }

                public static void Factorial(int value)
                {
                    
                    var result = 1;
                    
                    var isNegative = (value < 0); 
                    
                    if (isNegative)  
                        Console.WriteLine("The value " + value + " must be larger than 0 to calculate factorial.");
                    else
                    {
                        if (value == 0) 
                            Console.WriteLine(value+"! is equal to " + result);
                        else
                        {
                            for (int i = 1; i <= value; i++)
                            {
                                result *= i;
                            }
                            Console.WriteLine(value+"! is equal to " + result);
                        }
                    } 
                }
                public static float[] SortArray(float[] arr, bool isIncrease = false)
                {
                    
                    //Bubble sort.
                    int n = arr.Length;
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            if (!isIncrease)
                            {
                                if (arr[j] > arr[j + 1])
                                {
                                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                                }
                            }
                            else
                            {
                                if (arr[j] < arr[j + 1])
                                {
                                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                                }
                            }
                        }
                    }
                    return arr;
                }
    }
}