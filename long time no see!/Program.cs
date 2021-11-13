using System;

namespace long_time_no_see_
{
    class Program
    {
        static void The_Thing()
        {
            //درخواست عدد برای محاسبه بخش پذیری
            Console.Write("Enter The Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //درخواست عدد برای مشخص کردن بازه ی دامنه
            int First, Last;
            Console.Write("Enter The Number of Begin Domain : ");
            First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter The Number of End Domain : ");
            Last = Convert.ToInt32(Console.ReadLine());
            int[] Domain = { First, Last };
            //مقسوم
            //int Divisor = 0;
            //شمارش گر 
            int Counter = 0;
            //خارج قسمت
            int Quotient ;
            //شمارش اعداد از صفر تا عدد وارد شده در متغیر Domain
            for (int i=Domain[0]; i <= Domain[1]; i++)
            {
                //اضافه کردن یک عدد به مقدار قبلیِ مقسوم(متغیر Divisor)
                Domain[0]++;
                //اگر باقی مانده صفر بود کارهای زیر را انجام دهد
                if (Domain[0] % Number == 0)
                {
                    //به دست آوردن خارج قسمت
                    Quotient = Domain[0] / Number;
                    //اگر باقی مانده از 10 کوچک تر بود نتیجه زیر را نشان بده
                    if (Domain[0] < 10)
                    {
                        Console.Write(@"
 {0}  |  {1}
    |--------
    |   {2}
    |
    |
", Domain[0], Number, Quotient);
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
", Domain[0], Number, Quotient);
                    }
                    //به ازای چرخش هر حلقه یه مقدار به متغیر شمارش گر اضافه کن
                    Counter++;
                }
            }
            //نمایش تعداد اعداد بخش پذیر در بازه مشخص شده
            Console.WriteLine("There is {0} Divisible between {1} and {2}", Counter,Domain[0] ,Domain[1]);
            Console.WriteLine();
            Console.Write("Do ypu want to continue[y,n]? ");
            char choose = Convert.ToChar(Console.ReadLine());
            if (choose == 'y' || choose == 'Y')
            {
                 The_Thing();
            }
            else if (choose == 'n' || choose == 'N')
            {
                Console.WriteLine("See ya later!");
            }
            else
            {
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            The_Thing();       
        }
    }
}
