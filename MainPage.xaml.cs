using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_RIT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var topLabel = new Label(); 
            var bottomLabel = new Label();
            var nameLabel = new Label();

            topLabel.Text = "Hello"; 
            topLabel.FontSize = 48;
            topLabel.HorizontalTextAlignment = TextAlignment.Center;
            mainStack.Children.Add(topLabel);

            bottomLabel.Text = "RIT";
            bottomLabel.FontSize = 48;
            bottomLabel.HorizontalTextAlignment = TextAlignment.Center;
            mainStack.Children.Add(bottomLabel);

            nameLabel.Text = "Ben Goldfeder";
            nameLabel.FontSize = 24;
            nameLabel.Margin = new Thickness(0, 200, 0, 0);
            nameLabel.HorizontalTextAlignment = TextAlignment.Center;
            nameLabel.TextColor = Color.DimGray;
            mainStack.Children.Add(nameLabel);

            BackgroundColor = Color.Orange;

            //PART 2

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => { 
                await bottomLabel.TranslateTo(0, 410, 1500, Easing.BounceOut);
                await topLabel.TranslateTo(0, 550, 1500, Easing.BounceOut);
                await nameLabel.RotateTo(360, 2500, Easing.CubicInOut);
            };
            mainStack.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
