using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoraDoLanche : ContentPage
    {
        public HoraDoLanche()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Comer!!!") 
            {
                bt.Text = "Humm! Que gostoso!!!";
                photo.Source = "after_lilo_stick";
            }
            else
            {
                bt.Text = "Comer!!!";
                photo.Source = "before_lilo_stich";
            }
           
        }
    }
}