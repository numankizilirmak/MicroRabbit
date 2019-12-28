using MicroServicesRabitMq.WebApp.Models.DTO;
using System.Threading.Tasks;

namespace MicroServicesRabitMq.WebApp.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
