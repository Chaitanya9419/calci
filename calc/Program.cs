using System;

namespace calc
{
    class Program
    {
              public void show(double x)
        {
            Console.WriteLine("value of c:  " + x) ;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t*****WELCOME TO CALCULATOR APPLICATION*****");
            Console.WriteLine("\n");
           
                label:
            Program p1 = new Program();
            double result ,a, b;
            
            string ops;
            Console.WriteLine("value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("operator:('+' , '-' , '*' , '/' , 'p' for Percentage , '%' for Modulus , 's' for Square Root  , 'r' for Power Raising)");
            ops = Console.ReadLine();

            


            switch (ops)
            {
                

                case "+" :
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a + b; p1.show(result); break;
                case "-" :
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a - b; p1.show(result); break;
                case "*" :
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b; p1.show(result); break;
                case "/" :
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a / b; p1.show(result); break;
                case "p" :
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b / 100; p1.show(result); break;
                case "s" :
                    result = Math.Sqrt(a); p1.show(result); break;
                case "%":
                    //open chat window
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a % b;
                    p1.show(result);
                    break;
                case "r":
                    Console.WriteLine("value of b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(a, b);
                    p1.show(result);
                    break;
            }
            string ans;
            Console.WriteLine("Want to continue:(Y/N)");
            ans = Console.ReadLine();
            if (ans == "Y")
            {
                goto label;
            }
            else
            {
                 Console.ReadKey();            }
           
        }
    }
}
