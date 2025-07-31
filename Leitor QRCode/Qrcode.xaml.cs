namespace Leitor_QRCode;

public partial class Qrcode : ContentPage
{
	private bool isReading = true;

	public Qrcode()
	{
		InitializeComponent();
		barcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
		{
			Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
			AutoRotate = true,
			Multiple = false
		};
	}

    private void barcodeReader_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
		if (!isReading)
		{
			return;
		}

		var first = e.Results?.FirstOrDefault();

		if (first is null)
		{
			return;
		}

		isReading = false;

		Dispatcher.DispatchAsync(async () =>
		{
			await DisplayAlert("QR Code Detectado", first.Value, "Copiar");

			await Clipboard.SetTextAsync(first.Value);

			await DisplayAlert("Link Copiado", "O link foi copiado para a área de transferência.", "OK");

			isReading = true;
		});
    }
}