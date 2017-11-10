using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rubricon
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            
			InitializeComponent();
		}

        private void BtnCursos_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        async void btnRubricas_Clicked(object sender, EventArgs e)
        {
            
                var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
                Debug.WriteLine("Action: " + action);
           
        }
    }
}
