namespace Leitor_QRCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ScanButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Qrcode());
        }
    }
}
