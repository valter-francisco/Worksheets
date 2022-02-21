using System;
using System.Linq;
using System.Threading.Tasks;

namespace Worksheets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert Md#Id# to access an exercise");
            string menuInput = Console.ReadLine();
            menuInput = menuInput.Trim();

            switch (menuInput)
            {
                case "Md1":
                    int loopCounter = 0;
                    int[] numbers = new int[4];
                    do
                    {
                        string numberInput = AskNumberInput();
                        bool isNumber = IsNumber(numberInput);
                        if (isNumber)
                        {
                            numbers[loopCounter] = int.Parse(numberInput);
                            loopCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }while (loopCounter < 4);

                    int max = Ex1(numbers[0], numbers[1], numbers[2], numbers[3]);
                    Console.WriteLine("Your max is: " + max + ".");
                    break;

                case "Md2":

                    int loopCounter2 = 0;
                    int[] numbers2 = new int[2];
                    do
                    {
                        string numberInput = AskNumberInput();
                        bool isNumber = IsNumber(numberInput);
                        if (isNumber)
                        {
                            numbers2[loopCounter2] = int.Parse(numberInput);

                            bool verifyZero = VerifyZero(numbers2[loopCounter2]);
                            if (verifyZero)
                            {
                                Console.WriteLine("Invalid input, try again.");
                            }
                            else
                            {
                                loopCounter2++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }

                    } while (loopCounter2 < 2);

                    break;

                case "Md3":
                    break;

                case "Md4":
                    break;

                case "Md5":
                    break;

                   
            }
        }
        public static string AskNumberInput()
        {
            Console.WriteLine("Please insert a number");
            string numberInput = Console.ReadLine();
            numberInput = numberInput.Trim();
            return numberInput;
        }

        public static bool IsNumber(string numberInput)
        {
            try
            {
                int number = int.Parse(numberInput);
                return number >= 0;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static int Ex1(int numb1, int numb2, int numb3, int numb4)
        {
            int max;

            if (numb1 >= numb2)
            {
                max = numb1;
            }
            else
            {
                max = numb2;
            }

            if (numb3 >= numb4 && numb3 >= max)
            {
                max = numb3;
            }
            else if(numb4 >= max)
            {
                max = numb4;
            }
            return max;
        }

        public static bool VerifyZero(int isZero)
        {
            if (isZero == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float Ex2(float numb1,float numb2)
        {
            float div1 = numb1 / numb2;
            float div2 = numb2 / numb1;

            if (div1 > div2)
            {
                return div1;
            }
            else
            {
                return div2;
            }
        }

        public static bool VerifySumIsZero (float numb1, float numb2, float numb3)
        {
            float sum = numb1 + numb2 + numb3;
            if (sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float Ex3(float numb1, float numb2, float numb3, float numb4)
        {
            float max;

            float result1 = numb1 / (numb2 + numb3 + numb4);
            float result2 = numb2 / (numb1 + numb3 + numb4);
            float result3 = numb3 / (numb1 + numb2 + numb4);
            float result4 = numb4 / (numb1 + numb2 + numb3);

            float[] results = new float[3];
            results[0] = result1;
            results[1] = result2;
            results[2] = result3;
            results[3] = result4;

            max = results.Min();
            return max;

        }

        public static float Ex4(float numb1, float numb2)
        {
            float result = numb1 / numb2;
            Math.Round(result,2);
            return result;
        }

        public static string Ex5(float numb1, float numb2)
        {
            float result = numb1 * numb2;

            if(result % 2 == 0)
            {
                return "Bizz";
            }
            else
            {
                return "Buzz";
            }
        }
    }
}
