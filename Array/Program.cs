using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string[] students = new string[5]; 


for (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1}-ci tələbənin adını daxil edin: ");
    students[i] = Console.ReadLine(); 
}

Console.WriteLine("Daxil edilən tələbələr:");
foreach (string student in students)
{
    Console.WriteLine(student);
}