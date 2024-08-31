using CommunityToolkit.Maui; 

namespace NetMauiDelRegning
{
    public partial class MainPage : ContentPage
    {
        public decimal Amount { get; set; } = 1.0M; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void entryAmount_Completed(object sender, EventArgs e)
        {
            if (AmountValidator.IsNotValid)
            {
                DisplayAlert("Forkert Fakturabeløb", "Skal være større end 1", "OK");
                return;
            }

        }
        private void entryAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnPersonsFewer_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPersonsMore_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTips00_Clicked(object sender, EventArgs e)
        {

        }
        private void btnTips10_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTips15_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTips20_Clicked(object sender, EventArgs e)
        {

        }

    }
}
