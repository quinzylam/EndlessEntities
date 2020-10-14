using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EndlessEntities.Core.Models;
using EndlessEntities.ViewModels;

namespace EndlessEntities.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Entity Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}