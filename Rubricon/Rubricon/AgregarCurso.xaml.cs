﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rubricon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarCurso : ContentPage
	{
		public AgregarCurso ()
		{
			InitializeComponent ();
		}


        private void BtnAceptarCursos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}