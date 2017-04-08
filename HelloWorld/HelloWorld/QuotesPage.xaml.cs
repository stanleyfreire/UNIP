using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int index = 0;
        private string[] quotes = new string[]
        {
            "More Life",
            "More Everything",
            "Once More.."
        };

        public QuotesPage()
        {
            InitializeComponent();
            currentQuotes.Text = quotes[index];
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index >= quotes.Length)
                index = 0;

            currentQuotes.Text = quotes[index];
        }
    }
}
