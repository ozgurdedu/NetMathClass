using System;
using static NewMathApp.NewMath;
using static NewMathApp.Utils;

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

                    string input1, input2;
                    float num1, num2;
                    bool isNum1 = false, isNum2 = false;

                    while (true)
                    {
                        Console.Write("Input a number 1 : ");
                        input1 = Console.ReadLine();
                        Console.Write("Input a number 2 : ");
                        input2 = Console.ReadLine();
                        
                        //Are inputs number or not? 

                        if (float.TryParse(input1, out num1) && float.TryParse(input2, out num2))
                        {
                            isNum1 = true;
                            isNum2 = true; 
                            NewMath.Min(num1, num2);
                            
                            Console.WriteLine("If you want to try again please click any button.");
                            Console.WriteLine("@@@@@@");
                            Console.WriteLine("If you want to exit please click 'Q'.");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q")
                            {
                                Console.WriteLine("....SEE YOU MATE! WE'RE ALWAYS WITH YOU.");
                                return;
                            }
                        }
                        else {
                            Console.WriteLine("Wrong Input! Please input a number.");
                            Console.Write("Tab any button to try again, if you want to exit tab 'Q': ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q")
                                 {
                                    Console.WriteLine("....SEE YOU MATE! WE'RE ALWAYS WITH YOU.");
                                    return;
                                }
                        }
                        
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Can you input two values to find the maximum? ");

                    string input1max, input2max;
                    float num1max, num2max;
                    bool isNum1max = false, isNum2max = false;

                    while (true)
                    {
                        Console.Write("Input a number 1 : ");
                        input1max = Console.ReadLine();
                        Console.Write("Input a number 2 : ");
                        input2max = Console.ReadLine();
                        
                        //Are inputs number or not? 

                        if (float.TryParse(input1max, out num1max) && float.TryParse(input2max, out num2max))
                        {
                            isNum1max = true;
                            isNum2max = true; 
                            NewMath.Max(num1max, num2max);
                            
                            Console.WriteLine("If you want to try again please click any button.");
                            Console.WriteLine("@@@@@@");
                            Console.WriteLine("If you want to exit please click 'Q'.");
                            
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q") {
                                Console.WriteLine("....SEE YOU MATE! WE'RE ALWAYS WITH YOU.");
                                return;
                            }
                        }
                        else {
                            Console.WriteLine("Wrong Input! Please input a number.");
                            Console.Write("Tab any button to try again, if you want to exit tab 'Q': ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q") {
                                Console.WriteLine("....SEE YOU MATE! WE'RE ALWAYS WITH YOU.");
                                return;
                            }   
                        }
                        
                    }
                    break;
                case 3:
                    
                    string inputFactoriel;
                    bool isFactoriel = false;

                    while (true)
                    {
                        Console.WriteLine("Can you input a value to find the factorial? ");
                        inputFactoriel = Console.ReadLine();
                        
                        if (int.TryParse(inputFactoriel, out int value))
                        {
                            isFactoriel = true;
                            NewMath.Factorial(value);
                            
                            Console.WriteLine("If you want to try again please click any button.");
                            Console.WriteLine("@@@@@@");
                            Console.WriteLine("If you want to exit please click 'Q'.");
                            
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q") {
                                Console.WriteLine("....SEE YOU MATE! WE'RE ALWAYS WITH YOU.");
                                return;
                            }
                            

                        }
                        else
                        {
                            Console.WriteLine("Wrong Input! Please input a integer.");
                            Console.Write("Tab any button to try again, if you want to exit tab 'Q': ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "q") {
                                return;
                            }  
                        }
                    }
                   
                    
                    //NewMath.Factorial(value);
                    break;
                case 4:
                    Console.WriteLine("Can you input a number array separated  with comma? ");
                    float[] result = GetNumericArrayFromUserInput();

                    Console.WriteLine(@"< Press 1 > to sort the array smallest to largest ");
                    Console.WriteLine(@"< Press 2 > to sort the array largest to smallest ");
                    
                    int sortType = int.Parse(Console.ReadLine());

                    switch (sortType)
                    {
                        case 1:
                            var sortedArray1 = NewMath.SortArray(result, true);
                            string result1 = string.Join(",", sortedArray1);
                            Console.WriteLine("Sorted array is => " + "[ "+result1+" ]");
                            break;
                        case 2:
                            var sortedArray2 = NewMath.SortArray(result, true);
                            string result2 = string.Join(",", sortedArray2);
                            Console.WriteLine("Sorted array is => " + "[ "+result2+" ]");
                            break;
                    }

                    break;
            }
    
        }
    }
    
}