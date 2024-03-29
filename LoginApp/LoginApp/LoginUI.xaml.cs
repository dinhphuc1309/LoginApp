﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        private void Button_Clicked(Object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text =="123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Ops..","Alert", "Username or Password is incorrect!", "OK");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}