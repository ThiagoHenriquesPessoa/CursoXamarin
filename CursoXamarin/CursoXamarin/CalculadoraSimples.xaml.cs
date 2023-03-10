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
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnExecutar_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            double valorA = Convert.ToDouble(etValorA.Text);
            double valorB = Convert.ToDouble(etValorB.Text);
            double result;
            if (bt.Text == "+")
            {
                result = valorA + valorB;
            }
            else if (bt.Text == "-") 
            {
                result = valorA - valorB;
            }
            else if(bt.Text == "*") 
            {
                result = valorA * valorB;
            }
            else
            {
                result = valorA / valorB;
            }
            lbResposta.Text = result.ToString();
        }       
    }
}