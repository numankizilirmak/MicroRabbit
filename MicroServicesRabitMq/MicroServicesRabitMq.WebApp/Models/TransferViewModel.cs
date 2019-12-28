
namespace MicroServicesRabitMq.WebApp.Models
{
    public class TransferViewModel
    {
        public string Description { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
