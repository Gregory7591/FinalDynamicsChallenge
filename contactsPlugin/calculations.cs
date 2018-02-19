namespace FinalDynamicsChallenge.contactsPlugin
{
  public class Calculations
  {
    public decimal? CalculateAge(decimal? initialInvestment, decimal? investmentPeriod, int? rate)
    {
      return initialInvestment * (1 + (rate * investmentPeriod));
    }

  }
}