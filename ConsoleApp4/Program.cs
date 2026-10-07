namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Islam's Carpet Cleaning Service  Charges:  $25 per small $35 per large Sales tax rate is 6% Estimates are valid for 30 days");

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please enter the number of small carpets:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please enter the number of large carpets");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Estimate for carpet cleaning service");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                int s = num1 * 25;
                int l = num2 * 35;
                double t = (s + l) * 0.06;


                Console.WriteLine($"Number of small carpets : {num1}");
                Console.WriteLine($"Number of large carpets : {num2}");
                Console.WriteLine("Price per small carpet : $25");
                Console.WriteLine("Price per large carpet : $35");
                Console.WriteLine($"cost : {s + l}$");
                Console.WriteLine($"tax : ${t}");


                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Total estimate : {s + l + t}");
                Console.WriteLine("This estimate is valid for 30 days.");

            }
        }
    }

