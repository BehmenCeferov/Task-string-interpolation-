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


//WriteLine("Staj ilinizi qeyd edin: ");
//int yearsOfİnternship = ToInt32(ReadLine());
//double salary;
//if (yearsOfİnternship > 0 && yearsOfİnternship <= 2)
//{
//    salary = 2000;
//    WriteLine($"Sizin maaşınız {salary}");
//}
//else if (yearsOfİnternship > 3 && yearsOfİnternship <= 5)
//{
//    salary = 5000;
//    WriteLine($"Sizin maaşınız {salary}");
//}
//else if (yearsOfİnternship > 5 && yearsOfİnternship <= 10)
//{
//    salary = 7000;
//    WriteLine($"Sizin maaşınız {salary}");
//}
//else if (yearsOfİnternship > 10) 
//{
//    salary = 10000;
//    WriteLine($"Sizin maaşınız {salary}");
//}
//else
//{

//}

WriteLine("     Xoş gəlimisiniz!     ");
WriteLine("Menyu: ");
WriteLine("1 - İsti yemeklər");
WriteLine("2 - Qazan yeməkləri");
WriteLine("3 - içkilər");
WriteLine("4 - Desertlər");
short mainMenuselection = ToInt16(ReadLine());

switch (mainMenuselection)
{
    case 1:
        WriteLine("1 - Dolma");
        WriteLine("2 - Ev sayağı kartof");
        WriteLine("3 - Şaurma");
        WriteLine("4 - Toyuq Kababı");
        short hotMeals = ToInt16(ReadLine());
        switch (hotMeals)
        {
            case 1:
                WriteLine("Dolma sifariş edildi");
                break;
            case 2:
                WriteLine("Ev sayağı kartof sifariş edildi");
                break;
            case 3:
                WriteLine("Şaurma sifariş edildi");
                break;
            case 4:
                WriteLine("Toyuq Kababı sifariş edildi");
                break;
            default:
                break;
        }
        break;
    case 2:
        WriteLine("1 - Pulov");
        WriteLine("2 - Səbzi");
        WriteLine("3 - Xaş");
        WriteLine("4 - Qarnıyarıq");
        short potDishes = ToInt16(ReadLine());
        switch (potDishes)
        {
            case 1:
                WriteLine("Pulov sifariş edildi");
                break;
            case 2:
                WriteLine("Səbzi sifariş edildi");
                break;
            case 3:
                WriteLine("Xaş sifariş edildi");
                break;
            case 4:
                WriteLine("Qarnıyarıq");
                break;
            default:
                break;
        }
        break;
    case 3:
        WriteLine("1 - Qarışıq meyvə şirəsi");
        WriteLine("2 - Kola");
        WriteLine("3 - Çay");
        WriteLine("4 - Ayran");
        short drinks = ToInt16(ReadLine());
        switch (drinks)
        {
            case 1:
                WriteLine("Qarışıq meyvə şirəsi sifariş edildi");
                break;
            case 2:
                WriteLine("Kola sifariş edildi");
                break;
            case 3:
                WriteLine("Çay sifariş edildi");
                break;
            case 4:
                WriteLine("Ayran sifariş edildi");
                break;
            default:
                break;
        }
        break;
    case 4:
        WriteLine("1 - Şəkər çörəyi");
        WriteLine("1 - Şəkər çörəyi");
        WriteLine("2 - Karako");
        WriteLine("3 - Zinger");
        WriteLine("4 - Alma peroqu");
        short dessert = ToInt16(ReadLine());
        switch (dessert)
        {
            case 1:
                WriteLine("Şəkər çörəyi sifariş edildi");
                break;
            case 2:
                WriteLine("Karako sifariş edildi");
                break;
            case 3:
                WriteLine("Zinger sifariş edildi");
                break;
            case 4:
                WriteLine("Alma peroqu sifariş edildi");
                break;
            default:
                break;
        }
        break;
    default:
        break;
}

