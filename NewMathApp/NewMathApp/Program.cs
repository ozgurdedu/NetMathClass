using System;

namespace NewMathApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How can i help you ? \n");
        
            Console.WriteLine(@"< Press 1 > to find MINIMUM between two values");
            Console.WriteLine(@"< Press 2 > to find MAXIMUM between two values");
            Console.WriteLine(@"< Press 3 > to find FACTORIAL of the value");
            Console.WriteLine(@"< Press 4 > to  SORT the array");
        
        
            int choise = int.Parse(Console.ReadLine());
    
        
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Can you input two values to find the minimum? ");
                    float minV1 = float.Parse(Console.ReadLine());
                    float minV2 = float.Parse(Console.ReadLine());
                    NewMath.Min(minV1, minV2);
                    break;
                case 2:
                    Console.WriteLine("Can you input two values to find the maximum? ");
                    float maxV1 = float.Parse(Console.ReadLine());
                    float maxV2 = float.Parse(Console.ReadLine());
                    NewMath.Max(maxV1, maxV2);
                    break;
                case 3:
                    Console.WriteLine("Can you input a value to find the factorial? ");
                    int value = int.Parse(Console.ReadLine());
                    NewMath.Factorial(value);
                    break;
                case 4:
                    Console.WriteLine("Can you input a number array separated  with comma? ");
                    string input = Console.ReadLine();
                    string[] numbers = input.Split(',');
                    float[] nums = Array.ConvertAll(numbers, float.Parse);
                    
                    Console.WriteLine(@"< Press 1 > to sort the array smallest to largest ");
                    Console.WriteLine(@"< Press 2 > to sort the array largest to smallest ");
                    
                    int sortType = int.Parse(Console.ReadLine());

                    switch (sortType)
                    {
                        case 1:
                            var sortedArray1 = NewMath.SortArray(nums, true);
                            string result1 = string.Join(",", sortedArray1);
                            Console.WriteLine("Sorted array is => " + result1);
                            break; 
                        case 2:
                            var sortedArray2 = NewMath.SortArray(nums, false);
                            string result2 = string.Join(",", sortedArray2);
                            Console.WriteLine("Sorted array is => " + result2);
                            break;
                    }
                    
                    break;
            }
    
        }
    }
    
    
    
    
     class NewMath
            {
                public static void Min(float a, float b)
                {
                    var isEqual = (a == b);
                    if (!isEqual)
                    {
                        var minValue = (a < b) ? a : b; 
                        Console.WriteLine(":= MINIMUM VALUE is : " + minValue);
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
                        Console.WriteLine(":= MAXIMUM VALUE is : " + maxValue);
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
                public static float[] SortArray(float[] arr, bool isIncrease)
                {
                    if (isIncrease)
                        Array.Sort(arr);
                    else
                    {
                        Array.Sort(arr);
                        Array.Reverse(arr);
                    }
                    return arr;
                }
                
            }
}