using SodaMachine.Models;

namespace SodaMachine.Handlers
{
    public class CashHandler
    {
        List<CashModel> availableCash = new List<CashModel>();

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
    }
}
