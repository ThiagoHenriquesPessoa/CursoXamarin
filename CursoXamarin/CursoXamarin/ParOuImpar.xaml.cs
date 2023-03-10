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
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        private void btnExecutar_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32( etValor.Text);
            string resposta = "O número " + etValor.Text + " é ";
            if (numero % 2 == 0)
            {
                lblResposta.Text = resposta + "Par";
            }
            else
            {
                lblResposta.Text = resposta + "Impar";
            }
        }
    }
}