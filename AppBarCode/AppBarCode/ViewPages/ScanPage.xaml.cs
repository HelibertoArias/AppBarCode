using AppBarCode.Services;
using System;
using Xamarin.Forms;

namespace AppBarCode.ViewPages
{
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();

            btnScan.Clicked += BtnScan_Clicked;
        }

        private async void BtnScan_Clicked(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (result != null)
                barcode.Text = result;
        }
    }
}