using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoscope_Page : ContentPage
    {
        DatePicker dp;
        Label lbl, lbl_hor;
        string astro_sign, col_sign, year_sign;
        int day, month, year;
        List<string> animAr = new List<string> { "Ahv", "Kukk", "Koer", "Siga", "Rott", "Härg", "Jänes", "	Draakon", "Madu", "Hobune", "Lammas" };
        public Horoscope_Page()
        {
            lbl = new Label
            {
                Text = "Sissesta oma sünnipäev",
                TextColor = Color.Black
            };

            dp = new DatePicker
            {
                Format = "d",
                TextColor = Color.Black,

            };
            dp.DateSelected += Dp_DateSelected;

            lbl_hor = new Label
            {
                Text = ""
            };

            StackLayout st = new StackLayout
            {
                Children = { lbl, dp, lbl_hor }
            };
            
            Content = st;
        }

        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            day = e.NewDate.Day;
            month = e.NewDate.Month;
            year = e.NewDate.Year;
            int anim = year % 12;
            string year_sign;
            year_sign = animAr[anim];
            lbl.Text = "Oli valitud paev: " + e.NewDate.ToString("d");
            lbl.TextColor = Color.Black;
            Color_Year();
            Zodiac_sign();
            lbl_hor.Text = astro_sign + ", " + col_sign + " " + year_sign;
            lbl.TextColor = Color.Black;
        }
        public void Color_Year()
        {
            int col = year % 10;

            if (col == 0 || col == 1)
            {
                col_sign = "Valge";
                BackgroundColor = Color.White;
            }
            else if (col == 2 || col == 3)
            {
                col_sign = "Sinine";
                BackgroundColor = Color.LightBlue;
            }
            else if (col == 4 || col == 5)
            {
                col_sign = "Roheline";
                BackgroundColor = Color.LightGreen;
            }
            else if (col == 6 || col == 7)
            {
                col_sign = "Kollane";
                BackgroundColor = Color.LightYellow;
            }
            else if (col == 8 || col == 9)
            {
                col_sign = "Punane";
                BackgroundColor = Color.LightPink;
            }
        }

        public void Zodiac_sign()
        {

            if (month == 12)
            {

                if (day < 22)
                    astro_sign = "Ambur";
                else
                    astro_sign = "Kaljukits";
            }

            else if (month == 1)
            {
                if (day < 20)
                    astro_sign = "Kaljukits";
                else
                    astro_sign = "Veevalaja";
            }

            else if (month == 2)
            {
                if (day < 19)
                    astro_sign = "Veevalaja";
                else
                    astro_sign = "Kalad";
            }

            else if (month == 3)
            {
                if (day < 21)
                    astro_sign = "Kalad";
                else
                    astro_sign = "Jäär";
            }
            else if (month == 4)
            {
                if (day < 20)
                    astro_sign = "Jäär";
                else
                    astro_sign = "Sõnn";
            }

            else if (month == 5)
            {
                if (day < 21)
                    astro_sign = "Sõnn";
                else
                    astro_sign = "Kaksikud";
            }

            else if (month == 6)
            {
                if (day < 21)
                    astro_sign = "Kaksikud";
                else
                    astro_sign = "Vähk";
            }

            else if (month == 7)
            {
                if (day < 23)
                    astro_sign = "Vähk";
                else
                    astro_sign = "Lõvi";
            }

            else if (month == 8)
            {
                if (day < 23)
                    astro_sign = "Lõvi";
                else
                    astro_sign = "Neitsi";
            }

            else if (month == 9)
            {
                if (day < 23)
                    astro_sign = "Neitsi";
                else
                    astro_sign = "Kaallud";
            }

            else if (month == 10)
            {
                if (day < 23)
                    astro_sign = "Kaallud";
                else
                    astro_sign = "Skorpion";
            }

            else if (month == 11)
            {
                if (day < 22)
                    astro_sign = "Skorpion";
                else
                    astro_sign = "Ambur";
            }
        }
    }
}
