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
            //مقسوم
            int Divisor = 0;
            //شمارش گر 
            int Counter = 0;
            //خارج قسمت
            int Quotient = 0;
            //شمارش اعداد از صفر تا عدد وارد شده در متغیر Domain
            for (int i = 0; i < Domain; i++)
            {
                //اضافه کردن یک عدد به مقدار قبلیِ مقسوم(متغیر Divisor)
                Divisor++;
                //اگر باقی مانده صفر بود کارهای زیر را انجام دهد
                if (Divisor%Number==0)
                {
                    //به دست آوردن خارج قسمت
                    Quotient = Divisor / Number;
                    //اگر باقی مانده از 10 کوچک تر بود نتیجه زیر را نشان بده
                    if (Divisor < 10)
                    {
Console.Write(@"
 {0}  |  {1}
    |--------
    |   {2}
    |
    |
", Divisor, Number,Quotient);
                    }
                    //در غیر اینصورت نتیجه زیر را نشان بده
                    else
                    {
                        
Console.Write(@"
 {0} |  {1}
    |--------
    |  {2}
    |
    |
", Divisor, Number,Quotient);
                    }
                    //به ازای چرخش هر حلقه یه مقدار به متغیر شمارش گر اضافه کن
                    Counter++;
                }
            }
            //نمایش تعداد اعداد بخش پذیر در بازه مشخص شده
            Console.WriteLine("There is {0} Divisible between 0 and {1}",Counter,Domain);
            Console.ReadKey();
        }
    }
}
