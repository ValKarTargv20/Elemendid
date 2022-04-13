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
    public partial class Maa_Page : ContentPage
    {
        Label lbl;
        Picker maa_pi, pea_pi;
        Image img;
        List<string> Maakond = new List<string> { "Harjumaa", "Hiiumaa", "Ida - Virumaa", "Jõgevamaa", "Järvamaa", "Läänemaa", "Lääne - Virumaa", "Põlvamaa", "Pärnumaa", "Raplamaa", "Saaremaa", "Tartumaa", "Valgamaa", "Viljandimaa", "Võrumaa" };
        List<string> Pealinnad = new List<string> { "Tallinn", "Kärdla", "Jõhvi", "Jõgeva", "Paide", "Haapsalu", "Rakvere", "Põlva", "Pärnu", "Rapla", "Kuressaare", "Tartu", "Valga", "Viljandi", "Võru" };
        List<string> Lipud = new List<string> { "Harjumaa.png", "Hiiumaa.png", "IdaVirumaa.png", "Jogevamaa.png",
        "Jarvamaa.png", "Laanemaa.png", "LaaneVirumaa.png", "Polvamaa.png", "Parnumaa.png", "Raplamaa.png", "Saaremaa.png", "Tartumaa.png", "Valgamaa.png", "Viljandimaa.png", "Vorumaa.png"};
        
        public Maa_Page()
        {
            maa_pi = new Picker();
            for (int i = 0; i < 15;)
            {
                maa_pi.Items.Add(Maakond[i]);
                i++;
            }
            maa_pi.Title = "Maakonnad";
            maa_pi.SelectedIndexChanged += pi_SelectedIndexChanged;

            pea_pi = new Picker();
            for(int i = 0; i < 15; )
            {
                pea_pi.Items.Add(Pealinnad[i]);
                i++;
            }
            pea_pi.Title = "Pealinnad";
            pea_pi.SelectedIndexChanged += pi_SelectedIndexChanged;

            lbl = new Label
            {
                Text = "Siin on Maakond ja pealinn",
                TextColor=Color.Black
            };

            img = new Image
            {
                IsVisible = false
            };

            StackLayout st = new StackLayout
            {
                Children = { maa_pi, pea_pi, lbl, img }
            };
            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private void pi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == maa_pi)
            {
                pea_pi.SelectedIndex = maa_pi.SelectedIndex;
                lbl.Text = "Oli valitud maakond: " + maa_pi.Items[maa_pi.SelectedIndex] + ", pealinn on: " + pea_pi.Items[maa_pi.SelectedIndex];
                img.Source = Lipud[maa_pi.SelectedIndex];
                img.IsVisible = true;
            }
            else if (sender == pea_pi)
            {
                maa_pi.SelectedIndex = pea_pi.SelectedIndex;
                lbl.Text = "Oli valitud maakond: " + maa_pi.Items[pea_pi.SelectedIndex] + ", pealinn on: " + pea_pi.Items[pea_pi.SelectedIndex];
                img.Source = Lipud[pea_pi.SelectedIndex];
                img.IsVisible = true;
            }
        }

    }
}