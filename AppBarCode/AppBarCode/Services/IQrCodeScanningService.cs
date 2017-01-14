
using System.Threading.Tasks;

namespace AppBarCode.Services
{
   public interface IQrCodeScanningService
    {
       Task<string> ScanAsync();
    }
}
