using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooks
{
    public partial class App : Application
    {
        public static string _books_db = string.Empty;

        public App()
        {
            
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

        }

        public App(string books_db)
        {

            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            _books_db = books_db;

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
