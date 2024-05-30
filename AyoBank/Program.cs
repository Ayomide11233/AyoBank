Console.WriteLine("Welcome to AyoBank");
decimal CurrAccBal = 0;

Entry:
Console.WriteLine("To Withdraw press W , To Deposit press D ,To request for loans press R, To transfer press T,To exit press E");


string input = Console.ReadLine();
 
if (input.ToUpper() == "D")
{
    Console.WriteLine("How much do you want to deposit?");
    input = Console.ReadLine();
    CurrAccBal = Convert.ToDecimal(input) + CurrAccBal;
    Console.WriteLine($"Your Current Account Balance is N{CurrAccBal}");
    goto Entry;
}
    

if (input.ToUpper() == "W")
{
    Console.WriteLine("How Much do you want to withdraw?");
    input = Console.ReadLine();


    if (CurrAccBal- Convert.ToDecimal(input) < 0)
    {
        Console.WriteLine( "Insufficient Balance!");

    }
    else
    {

        Console.WriteLine($"Here's your {input}");  
        CurrAccBal =  CurrAccBal - Convert.ToDecimal(input);

        Console.WriteLine($"Your Current Account Balance is N{CurrAccBal}");

    }
    goto Entry;

}
if (input.ToUpper().Trim() == "R")
{
    Console.WriteLine("How much do you want borrow?");
    input = Console.ReadLine();
    decimal Loan = Convert.ToDecimal(input);
    decimal Currdebt = 0;
    decimal interestrate = 0.05M;
    Console.WriteLine("Do you consent to a 5% interest rate, Press Y to say yes, Press N to say No ");
    input = Console.ReadLine();
    if(input.ToUpper() == "Y")
    {
        CurrAccBal = Loan + CurrAccBal;
        Console.WriteLine($"You have been granted the sum of {Loan}.So your current acount balance is {CurrAccBal}");
        Currdebt = Loan + (Loan * interestrate);
        Console.WriteLine($"Current debt after Month {1} is {Currdebt}");

        for (int i = 1; i <6; i++)
        {         

            Currdebt = Currdebt + (Currdebt * interestrate);     
            Console.WriteLine($"Current debt after Month {i+1} is {Currdebt}");

        }
    
    }
    if (input.ToUpper() == "N")
    {
        Console.WriteLine("");
    } 
    goto Entry;

}

