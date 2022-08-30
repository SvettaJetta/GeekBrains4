using System;

namespace GeekBrains04
{
    class Program
    {

        static int task25(int a, int n)
        {
            int result = Convert.ToInt32(Math.Pow(a,n));

            return result;

        }

        static int task27(int number)
        {
            String str = Convert.ToString(number);
            int result = 0;

            foreach (var x in str)
            {
                result += Convert.ToInt32(x.ToString());                
            }
            return result;

        }
        static void task29(int n, int min, int max)
        {
            int[] numbers = new int[n];
            for(int i = 0; i < numbers.Length;)
            {
                Random rnd = new Random();
                int value = rnd.Next(min,max);

                numbers.SetValue(value,i);
               
                i++;

            }    
            Console.WriteLine("");        

            foreach(int num in numbers)
            {
                Console.Write($"{num} \t");
            }
            

        }


        static void Main(string[] args)
        {
            Console.WriteLine("task25");
            Console.WriteLine("Enter powed numbers ");
            int num = int.Parse((Console.ReadLine()));
            int n = int.Parse((Console.ReadLine()));
            Console.WriteLine(task25(num,n));

            Console.WriteLine("task27");
            Console.WriteLine("Enter value for get sum of numbers  ");
            int number = int.Parse((Console.ReadLine()));            
            Console.WriteLine(task27(number));

            Console.WriteLine("task29");
            Console.WriteLine("Enter value of numbers in array");
            int nu = int.Parse(Console.ReadLine());  
            Console.WriteLine("Enter min value");
            int min = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter max value");
            int max = int.Parse(Console.ReadLine());                                  
            task29(nu, min, max);

            
        }
    }
}
