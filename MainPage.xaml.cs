using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace BarCodeScanner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //WindowsUniversal.Platform.Init();
        }
        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
           // count++;
           // ((Button)sender).Text = $"You clicked {count} times.";

            Task.Run(()=> testcAsync());
            // Navigate to our scanner page
            // await Navigation.PushAsync(scanPage);

        }

        private async Task testcAsync()
        {
           // var scanPage = new ZXingScannerPage();
            

            //await Navigation.PushAsync(scanPage);
            var scanPage = new MobileBarcodeScanner();
            ZXing.Result result1 = await scanPage.Scan();

           
        }
    }
}
