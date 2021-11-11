using System;

namespace long_time_no_see_
{
    class Program
    {
        static void Main(string[] args)
        {
            //درخواست عدد برای محاسبه بخش پذیری
            Console.WriteLine("Enter The Number :");
            int Number = Convert.ToInt32(Console.ReadLine());
            //درخواست عدد برای مشخص کردن بازه ی دامنه
            Console.WriteLine("Enter The Number of Domain :");
            int Domain = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int j = 0;
            int kh = 0;
            for (int i = 0; i < Domain; i++)
            {
                s++;
                if (s%Number==0)
                {
                    kh = s / Number;

                    if (s < 10)
                    {
Console.Write(@"
 {0}  |  {1}
    |--------
    |   {2}
    |
    |
", s, Number,kh);
                    }
                    else
                    {
                        
Console.Write(@"
 {0} |  {1}
    |--------
    |  {2}
    |
    |
", s, Number,kh);
                    }
                    j++;
                }
            }
            Console.WriteLine("There is {0}",j);
            Console.ReadKey();
        }
    }
}
