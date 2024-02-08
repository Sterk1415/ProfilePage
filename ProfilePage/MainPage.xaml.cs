namespace ProfilePage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs args)
        {
            await DisplayAlert("Attention", "This part is still under contruction (˶╥︿╥)", "ok");
        }
    }
     
}
