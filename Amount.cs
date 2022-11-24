public class Amount
{
    public decimal DepositValue { get; init; }
    public decimal RateValue { get; init; }
    public int Instalments { get; init; }

    public Amount(decimal depositValue, decimal rateValue, int instalments)
    {
        DepositValue = depositValue;
        RateValue = rateValue;
        Instalments = instalments;
    }

    public decimal CalculateComposedAmount() => Math.Round(((((RateValue / 12) * Instalments) * (DepositValue * Instalments) / 100) + (DepositValue * Instalments)), 2);

    public decimal CalculateAmount() => Math.Round((DepositValue * Instalments), 2);

    public decimal CalculateRates() => CalculateComposedAmount() - CalculateAmount();
}