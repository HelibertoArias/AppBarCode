using AppBarCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(result!=null)
                barcode.Text = result;

             

        }
    }
}
