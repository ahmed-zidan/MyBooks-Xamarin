using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyBooks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            using(SQLite.SQLiteConnection conn= new SQLite.SQLiteConnection(App._books_db))
            {
                conn.CreateTable<Book>();
                var books = conn.Table<Book>().ToList();
                lstBooks.ItemsSource = books;

            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new NewBookPage());

        }
    }
}
