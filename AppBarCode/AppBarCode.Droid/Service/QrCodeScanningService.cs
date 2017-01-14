using AppBarCode.Services;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly:Dependency(typeof(AppBarCode.Droid.Service.QrCodeScanningService))]
namespace AppBarCode.Droid.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions() {
                AutoRotate = false,
               //UseFrontCameraIfAvailable = true,
                TryHarder=true
                //Check diferents formats in http://barcode.tec-it.com/en
               // PossibleFormats = new List<ZXing.BarcodeFormat> {  ZXing.BarcodeFormat.CODE_128 }
            };
            var scanner = new MobileBarcodeScanner() {
                                  TopText = "Acerca la cámara al elemento",
                                  BottomText = "Toca la pantalla para enfocar"
            };
            


            var scanResults = await scanner.Scan(optionsCustom);
            return scanResults.Text;

        }
    }
}