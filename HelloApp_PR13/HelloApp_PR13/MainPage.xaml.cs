using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloApp_PR13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TapGestureRecognizer tapGesture = new TapGestureRecognizer(); 
            int count = 0;
            tapGesture.Tapped += (s, e) => { 
                count++;
                label1.Text = $"2 в степени {count} = {(Math.Pow(2, count))}"; 
            };

            label1.GestureRecognizers.Add(tapGesture);
        }

        private int Factorial(int num) {
            int f = 1;

            for (int i = 1; i <= num; i++) {
                f *= i;
            }
            return f;
        }

        private void OnButtonClicked(object sender, EventArgs e) {
            try
            {
                int num = Convert.ToInt32(factorialEntry.Text);

                if (num > 0)
                {
                    label2.TextColor = Color.Black;
                    label2.Text = Factorial(num).ToString();
                }
                else
                {
                    label2.TextColor = Color.Green;
                    label2.Text = "Введите число больше нуля! >:с";
                }
            }
            catch 
            {
                label2.TextColor = Color.DarkGreen;
                label2.Text = "Введите число! >:с";
            }
        }
    }
}
