﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EsoBuildEditor.Services;
using EsoBuildEditor.Views;

namespace EsoBuildEditor
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
