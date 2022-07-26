using SodaMachine.Models;

namespace SodaMachine.Handlers
{
    public class CashHandler
    {
        List<CashModel> cash = new List<CashModel>();

        public CashHandler()
        {
            var builder = WebApplication.CreateBuilder();
        }

    }
}
