using static System.Console;

Phone phone = new Phone();
phone.name = "Iphone";
phone.model = "11 Pro";
phone.price = 1300;
phone.ShowNameAndModel();
int monthlyPayment = phone.CalcCredit(6, 10);
WriteLine("Monthly payment: " + monthlyPayment);
public class Phone
{
    public string name;
    public string model;
    public int price;
    public void ShowNameAndModel()
    {
        WriteLine($"Name: {name}, Model: {model}");
    }
    public int CalcCredit(int month, int persentage)
    {
        int monthlyPayment = (price / month) * (1 + persentage / 100);
        WriteLine(monthlyPayment);
        return monthlyPayment;
    }
}
