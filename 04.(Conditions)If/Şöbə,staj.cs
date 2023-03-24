using System.Text;
using static System.Console;
using static System.Convert;
OutputEncoding = Encoding.UTF8;

//string department = ReadLine();
//if (department == "HR")
//{
//    WriteLine("İnsan Resursları şöbəsi");
//}
//else if (department == "Finance")
//{
//    WriteLine("Finans şöbəsi yazsın");
//}
//else if (department == "IT")
//{
//    WriteLine("İnformasiya texnologiyaları şöbəsi");
//}
//else
//{
//    WriteLine("Belə bir şöbə yoxdur");
//}


WriteLine("Staj ilinizi qeyd edin: ");
int yearsOfİnternship = ToInt32(ReadLine());
double salary;
if (yearsOfİnternship > 0 && yearsOfİnternship <= 2)
{
    salary = 2000;
    WriteLine($"Sizin maaşınız {salary}");
}
else if (yearsOfİnternship > 3 && yearsOfİnternship <= 5)
{
    salary = 5000;
    WriteLine($"Sizin maaşınız {salary}");
}
else if (yearsOfİnternship > 5 && yearsOfİnternship <= 10)
{
    salary = 7000;
    WriteLine($"Sizin maaşınız {salary}");
}
else if (yearsOfİnternship > 10) 
{
    salary = 10000;
    WriteLine($"Sizin maaşınız {salary}");
}
else
{

}