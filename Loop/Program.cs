using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//3-cu tapshiriq
//int number = 304001;
//int positiveSum = 0;
//int nonZeroDigitCount = 0;

//while (number > 0)
//{
//    int digit = number % 10;
//    if (digit > 0)
//    {
//        positiveSum += digit;
//        nonZeroDigitCount++;
//    }
//    number /= 10;
//}

//Console.WriteLine("Müsbət rəqəmlərin cəmi: " + positiveSum);
//Console.WriteLine("Müsbət və mənfi olmayan rəqəmlərin sayı: " + nonZeroDigitCount);

// 1-ci tapshiriq
//long digit = 1;
//long result = 1;
//for (digit = 1; digit <= 50; digit += 3) 
//{
//    result *= digit;
//    digit += 3; 
//}
//Console.WriteLine(hasil);

//2-ci tapsiriq
//Console.OutputEncoding = Encoding.UTF8;
//int sum = 0;
//int result2 = 1;
//int singleDigitCount = 0;
//for (int i = -30; i <=28; i++)
//{
//    if(i % 3 == 0 && i % 6 == 0)
//    {
//        sum += i;
//    }
//    if(i % 5 == 0 || i % 2 == 0)
//    {
//        result2 *= i;
//    }
//    if (i % 2 != 0)
//    {
//        singleDigitCount++;
//    }
//}
//Console.WriteLine($"Həm 3 həm 6 bölünən ədədlərin cəmi: {sum}");
//Console.WriteLine($"5 və ya 2 -  ə bölünənlərin hasili: {result2}");
//Console.WriteLine($"Tək ədədlərin sayı: {singleDigitCount}");
int limit = 3;
int count = 0;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("login: ");
    string login = Console.ReadLine();
    Console.WriteLine("password: ");
    string password = Console.ReadLine();
        if (login == "booleanteach" && password == "booleanms13")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sistemə daxil oldunuz!");
            break;
        }
        else if (login != "booleanteach" && password != "booleanms13")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Login və şifrə yanlışdır!");
        }
        else if (login != "booleanteach" && password == "booleanms13")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("login yalışdır!");
        }
        else if (login == "booleanteach" && password != "booleanms13")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Şifrə yanlışdır!");
        }
    count++;
} while (count != limit);

if (count == limit)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sistem bloklanmışdır!");
}

