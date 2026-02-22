
Console.WriteLine("enter the bill amount : ");

double amount = Convert.ToDouble(Console.ReadLine());

if (amount <= 0)
{
    Console.WriteLine("invaild number");
}


else if (amount >= 500)
{
    double amount_1 = amount * 30/100;
    double finalamount = amount- amount_1;
    Console.WriteLine($"final price :{finalamount} ");
}
else if (amount >= 300 && amount <= 499)
{
    float amount_2 = (float) amount * 10/100  ;
    double finalamount_1= amount - amount_2;

    Console.WriteLine($"final price :{finalamount_1} ");

}
else if (amount <300)
{
    float amount_3 =  (float) amount;
    double finalamount_2 = amount - amount_3;

    Console.WriteLine($"final price :{finalamount_2} ");

}

