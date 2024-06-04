using Task1;

public class Program
{
    public static void Main(string[] args)
    {
        IAccount regularAccount = new RegularAccount { Balance = 1500 };
        Calculator.CalculateInterest(regularAccount);
        Console.WriteLine($"Процентная ставка для обычного аккаунта: {regularAccount.Interest}");

        IAccount salaryAccount = new SalaryAccount { Balance = 1500 };
        Calculator.CalculateInterest(salaryAccount);
        Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");
    }
}