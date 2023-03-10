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
    public partial class CalculadoraGrid : ContentPage
    {
        int currentState = 1;
        string mathOprator;
        double fistNumber, secondNumber;

        public CalculadoraGrid()
        {
            InitializeComponent();
            btnOnClear_Clicked(new object(), new EventArgs());
        }

        private void btnOnClear_Clicked(object sender, EventArgs e)
        {
            fistNumber = 0;
            secondNumber = 0;
            currentState = 1;
            lbResultText.Text = "0";
        }

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (lbResultText.Text == "0" || currentState < 0)
            {
                lbResultText.Text = "";
                if (currentState < 0)
                {
                    currentState *= -1;
                }
            }

            lbResultText.Text += pressed;
            double number;
            if (double.TryParse(lbResultText.Text, out number))
            {
                lbResultText.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    fistNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        void OnSelectOprator(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            mathOprator = pressed;
        }
       
        void OnCalculate(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double result = 0;
                if (mathOprator == "+") 
                {
                    result = fistNumber + secondNumber;
                }
                if (mathOprator == "-")
                {
                    result = fistNumber - secondNumber;
                }
                if (mathOprator == "/")
                {
                    result = fistNumber / secondNumber;
                }
                if (mathOprator == "x")
                {
                    result = fistNumber * secondNumber;
                }

                lbResultText.Text = result.ToString();
                fistNumber = result;
                currentState = -1;
            }           
        }
    }
}