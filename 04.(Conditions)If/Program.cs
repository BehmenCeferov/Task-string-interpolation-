using System.Text;
using static System.Console;
using static System.Convert;
OutputEncoding = Encoding.UTF8;

string department = ReadLine();
if (department == "HR")
{
    WriteLine("İnsan Resursları şöbəsi");
}
else if (department == "Finance")
{
    WriteLine("Finans şöbəsi yazsın");
}
else if (department == "IT")
{
    WriteLine("İnformasiya texnologiyaları şöbəsi");
}
else
{
    WriteLine("Belə bir şöbə yoxdur");
}
