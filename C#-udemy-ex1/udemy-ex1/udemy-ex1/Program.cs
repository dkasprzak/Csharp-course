using System;

namespace UdemyEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("insert numbers:");

            int userinput = int.Parse(Console.ReadLine());

            int sum = 0;

            int? maxvalue = null;

            while(userinput != 0)
            {
                if(maxvalue == null || userinput > maxvalue)
                {
                    maxvalue = userinput;
                }

                sum += userinput;

                userinput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"sum of numbers = {sum}");
            if (maxvalue != null)
            {
                Console.WriteLine($"max value = {maxvalue}");
            }
            else
            {
                Console.WriteLine("max value = no values inserted!");
            }

            */

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Insert value:");
            int doValue = 0; 
            
            int sum2 = 0;

            int? maxValue2 = null;

            do
            { 
                doValue = int.Parse(Console.ReadLine());
                if (maxValue2 == null || doValue > maxValue2)
                {
                    maxValue2 = doValue;
                }
                sum2 += doValue;
            } while (doValue != 0);
            Console.WriteLine($"sum = {sum2}");
            if (maxValue2 == 0)
            {
                Console.WriteLine($"No values inserted");
            }
            else
            {
                Console.WriteLine($"max value = {maxValue2}");
            }
        }
    }
}
