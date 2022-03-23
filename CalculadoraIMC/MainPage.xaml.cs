using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = double.Parse(peso_digitado.Text);
            double altura = double.Parse(altura_digitada.Text);
            double altura_2 = (altura * altura);

            double imc = (peso / altura_2);

            if (imc < 18.5) {
                resultado.Text = $"Seu IMC é de {imc.ToString("F2")}\nVocê está classificado como [Magreza]";
            } else if (imc >= 18.5 && imc < 24.9) {
                resultado.Text = $"Seu IMC é de {imc.ToString("F2")}\nVocê está classificado como [Normal]";
            } else if (imc >= 25 && imc < 29.9) {
                resultado.Text = $"Seu IMC é de {imc.ToString("F2")}\nVocê está classificado como [Sobrepeso]";
            } else if (imc >= 30 && imc <39.9) {
                resultado.Text = $"Seu IMC é de {imc.ToString("F2")}\nVocê está classificado como [Obesidade]";
            } else {
                resultado.Text = $"Seu IMC é de {imc.ToString("F2")}\nVocê está classificado como [Obesidade Grave]";
            }

            peso_digitado.Text = "";
            altura_digitada.Text = "";

            
        }
    }
}
