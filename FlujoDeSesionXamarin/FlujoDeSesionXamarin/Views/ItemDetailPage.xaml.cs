﻿using FlujoDeSesionXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FlujoDeSesionXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}