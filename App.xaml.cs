﻿namespace JestrellaS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Login());
        }
    }
}
