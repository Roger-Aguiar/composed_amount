Console.Clear();

var currentDate = DateTime.Now;

Console.Write("Enter the deposit value: ");
decimal depositValue = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the rate value: ");
decimal rateValue = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the number of installment(s): ");
int installment = Convert.ToInt32(Console.ReadLine());

var amount = new Amount(depositValue, rateValue, installment);

Console.Clear();
Console.WriteLine(String.Format("Initial date: {0:MM/dd/yyyy}", currentDate));
Console.WriteLine("\nAmount: " + String.Format("{0:C}", amount.CalculateAmount()));
Console.WriteLine("Composed amount: " + String.Format("{0:C}", amount.CalculateComposedAmount()));
Console.WriteLine("Rates: " + String.Format("{0:C}", amount.CalculateRates()));

Console.WriteLine(String.Format("\nIf you deduct {0:C} each month, in {1:MM/dd/yyyy} you will have {2:C}.", depositValue, currentDate.AddMonths(installment), amount.CalculateComposedAmount()));

Console.WriteLine("\nPress any key to exit the application...");
Console.ReadKey();
