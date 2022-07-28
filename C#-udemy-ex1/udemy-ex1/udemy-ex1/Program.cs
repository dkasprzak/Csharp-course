using System;

namespace UdemyEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers:");

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

            Console.WriteLine($"Sum of numbers = {sum}");
            if (maxvalue != null)
            {
                Console.WriteLine($"Max value = {maxvalue}");
            }
            else
            {
                Console.WriteLine("Max value = No values inserted");
            }
        }
    }
}
