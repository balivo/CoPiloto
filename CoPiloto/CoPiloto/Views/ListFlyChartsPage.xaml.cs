﻿using CoPiloto.Models;
using CoPiloto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoPiloto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFlyChartsPage : ContentPage
    {
        public ListFlyChartsPage()
        {
            InitializeComponent();
        }

        void Charts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is null) return;

            (BindingContext as ListFlyChartsViewModel).ChartSelectedCommand.Execute(((Approach)e.Item).Url);

        }
    }
}