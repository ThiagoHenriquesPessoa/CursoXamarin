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
    public partial class ComprarCafe : ContentPage
    {
        public int Qtde { get; set; }
        public Double ValorUnd { get; set; }
        public Double Total { get; set; }
        public ComprarCafe()
        {
            InitializeComponent();
            Qtde = 0;
            ValorUnd = 5;
            Total = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "-")
            {
                if (Qtde > 0)
                {
                    Qtde--;
                }
            }
            else
            {
                Qtde++;
            }
            Total = Qtde * ValorUnd;
            lTotal.Text = "Total R$ " + Total.ToString() + ",00";
            lQtde.Text = "Quantidade: " + Qtde.ToString();
        }
    }
}