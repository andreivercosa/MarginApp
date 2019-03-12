using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarginApp
{
    
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
           
        }

        void equilibrio(object sender, System.EventArgs e)
        {

            int i = Convert.ToInt32(slider.Value);
            if (i == 0 || i == 360)
            {
                rodante.Text = "-- Estavel --";
            }
            else
            {
                rodante.Text = "-- Girando --";
            }
            label_valueSlider.Text = i.ToString();
        }



    }
}
