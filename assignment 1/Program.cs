
Console.WriteLine("enter the bill amount : ");

double amount = Convert.ToDouble(Console.ReadLine());

if (amount >= 500)
{
    double amount_1 = amount * 30/100;
    Console.WriteLine($"final price :{amount_1} ");
}
else if (amount >= 300 && amount <= 499)
{
    float amount_1 = (float) amount * 10/100  ;
    Console.WriteLine($"final price :{amount_1} ");

}
else if (amount <300)
{
    float amount_1 =  (float) amount;
    Console.WriteLine($"final price :{amount_1} ");

}

