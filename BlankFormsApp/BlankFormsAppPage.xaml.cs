using Xamarin.Forms;
using System;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp {
    public partial class BlankFormsAppPage : ContentPage {
        public BlankFormsAppPage() {
            InitializeComponent();

            StackLayout layout = new StackLayout {
                Margin = 20,
            };

            Button btn = new Button {
                Text = "click"
            };

			btn.Clicked += (object sender, System.EventArgs e) => {
                Button button = (Button)sender;
				DisplayAlert("Clicked!", "The button labeled '" + button.Text + "' has been clicked", "OK");
			};

            Label label = new Label {
                Text = "Hola"
            };

            layout.Children.Add(label); 
            layout.Children.Add(btn);


            this.Content = layout;
        }
    }
}
