
using System;
using CrmEarlyBound;

namespace CrmCalculations
{
  public class Calculations
  {
    public void CalculateAge(Contact contact, Contact preContact)
    {
      DateTime dateCurrent = DateTime.Now.Date;
      DateTime dateBirth = contact.GetAttributeValue<DateTime>("birthdate");
      int dateDiff = dateCurrent.Month - dateBirth.Month;

      if (dateDiff > -1)
      {
        contact.di_age = dateCurrent.Year - dateBirth.Year;
      }
      else
      {
        contact.di_age = dateCurrent.Year - dateBirth.Year - 1;
      }



    }
    public decimal? CalculateEstReturn(Contact contact, Contact preContact)
    {
      decimal? initialInvestment = contact.di_IntialInvesmentFinal;
      decimal? interestRate = contact.di_interest_rate / 100;
      int? investmentPeriod = contact.di_InvestmentPeriod;

      contact.di_joining_date = DateTime.Now.Date;
      contact.di_maturity_date = DateTime.Now.Date.AddMonths((int)(contact.di_InvestmentPeriod));
      return initialInvestment * (1 + (interestRate * investmentPeriod));

    }

  }
}