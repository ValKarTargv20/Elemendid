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
        List<string> Maakond = new List<string> { "Harjumaa", "Hiiumaa", "Ida - Virumaa", "Jõgevamaa", "Järvamaa", "Läänemaa", "Lääne - Virumaa", "Põlvamaa", "Pärnumaa", "Raplamaa", "Saaremaa", "Tartumaa", "Valgamaa", "Viljandimaa", "Võrumaa" };
        List<string> Pealinnad = new List<string> { "Tallinn", "Kärdla", "Jõhvi", "Jõgeva", "Paide", "Haapsalu", "Rakvere", "Põlva", "Pärnu", "Rapla", "Kuressaare", "Tartu", "Valga", "Viljandi", "Võru" };
        List<string> Lipud = new List<string> { "Harjumaa.png", "Hiiumaa.png", "IdaVirumaa.png", "Jogevamaa.png",
        "Jarvamaa.png", "Laanemaa.png", "LaaneVirumaa.png", "Polvamaa.png", "Parnumaa.png", "Raplamaa.png", "Saaremaa.png", "Tartumaa.png", "Valgamaa.png", "Viljandimaa.png", "Vorumaa.png"};
        Label lbl;
        Picker maa_pi, pea_pi;
        public Maa_Page()
        {
            BackgroundColor = Color.LightBlue;
            maa_pi = new Picker
            {
                Title="Maakonnad",
            };
            maa_pi.SelectedIndexChanged += Maa_pi_SelectedIndexChanged;
            pea_pi = new Picker
            {
                Title="Pealinnad"
            };
            pea_pi.SelectedIndexChanged += Pea_pi_SelectedIndexChanged;
            StackLayout st = new StackLayout
            {
                Children = { maa_pi, pea_pi, lbl }
            };
            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private void Pea_pi_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Maa_pi_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}