using SodaMachine.Models;

namespace SodaMachine.Handlers
{
    public class CashHandler
    {
        List<CashModel> availableCash = new List<CashModel>();
        List<CashModel> cashAllowed = new List<CashModel>();

        public CashHandler()
        {
            var builder = WebApplication.CreateBuilder();
        }
        
        public List<CashModel> GetAvailableCash()
        {
            availableCash.Add(new CashModel { Type = "coin", Value = 500, Quantity = 20});
            availableCash.Add(new CashModel { Type = "coin", Value = 100, Quantity = 30 });
            availableCash.Add(new CashModel { Type = "coin", Value = 50, Quantity = 50 });
            availableCash.Add(new CashModel { Type = "coin", Value = 25, Quantity = 25 });
            return availableCash;
        }

        public List<CashModel> GetAllowedCash()
        {
            cashAllowed.Add(new CashModel { Type = "coin", Value = 500, Quantity = 0 });
            cashAllowed.Add(new CashModel { Type = "coin", Value = 100, Quantity = 0 });
            cashAllowed.Add(new CashModel { Type = "coin", Value = 50, Quantity = 0 });
            cashAllowed.Add(new CashModel { Type = "coin", Value = 25, Quantity = 0 });
            cashAllowed.Add(new CashModel { Type = "bill", Value = 1000, Quantity = 0 });
            return cashAllowed;
        }
    }
}
