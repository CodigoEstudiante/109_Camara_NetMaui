namespace CamaraNetMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var foto = await MediaPicker.CapturePhotoAsync();

            if(foto != null)
            {
                var memoriaStream = await foto.OpenReadAsync();
                imgFoto.Source = ImageSource.FromStream(() => memoriaStream);
            }

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var foto = await MediaPicker.PickPhotoAsync();

            if (foto != null)
            {
                var memoriaStream = await foto.OpenReadAsync();
                imgFoto.Source = ImageSource.FromStream(() => memoriaStream);
            }

        }
    }
}