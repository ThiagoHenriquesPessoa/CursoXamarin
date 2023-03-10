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
            int result;
            if (bt.Text == "+")
            {
                result = Convert.ToInt32(etValorA.Text) + Convert.ToInt32(etValorB.Text);
            }
            else if (bt.Text == "-") 
            {
                result = Convert.ToInt32(etValorA.Text) - Convert.ToInt32(etValorB.Text);
            }
            else if(bt.Text == "*") 
            {
                result = Convert.ToInt32(etValorA.Text) * Convert.ToInt32(etValorB.Text);
            }
            else
            {
                result = Convert.ToInt32(etValorA.Text) / Convert.ToInt32(etValorB.Text);
            }
            lbResposta.Text = Convert.ToString(result);
        }       
    }
}