using System;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        Button maa_btn, hor_btn, aja_btn;
        public MainPage()
        {
            
            maa_btn = new Button
            {
                Text = "Maakonnad",
                TextColor = Color.White,
                BackgroundColor = Color.Blue
            };
            maa_btn.Clicked += StartP;

            hor_btn = new Button
            {
                Text = "Horoskoop",
                TextColor = Color.White,
                BackgroundColor = Color.Black
            };
            hor_btn.Clicked += StartP;

            aja_btn = new Button
            {
                Text = "Ajaplaan",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };
            aja_btn.Clicked += StartP;

            StackLayout st = new StackLayout
            {
                Children = { maa_btn, hor_btn, aja_btn }
            };
            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }
        private async void StartP(object sender, EventArgs e)
        {
            if (sender == maa_btn)
            {
                await Navigation.PushAsync(new Maa_Page());
            }
            else if (sender == hor_btn)
            {
                await Navigation.PushAsync(new Horoscope_Page());
            }
            else if (sender== aja_btn)
            {
                await Navigation.PushAsync(new Ajaplaan_Page());
            }
        }
    }
}
