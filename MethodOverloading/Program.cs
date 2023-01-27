namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double c, double d)
        {
            return (c + d);
        }

        public static string Add(int e, int f, bool isTrue)
        {
            var sum = e + f;
           

            if (isTrue == true && sum > 1)
            {
                return  ($"{sum} dollars");
                
            }
            else if ( isTrue == true && sum == 1)
            {
                return  ($"{sum} dollar");
            }
            else if (isTrue == true && sum < 1)
            {
                return ($"{sum} dollars");
            }
            else
            {
                return sum.ToString();
            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Add(15 , 17));
            Console.WriteLine(Add(0.7 , 0.9));
            Console.WriteLine(Add(0 , 0 , false));
        }
    }
}
