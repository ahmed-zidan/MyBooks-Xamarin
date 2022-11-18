using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Book book = new Book
            {
                Auther = entAuther.Text,
                BookName = entName.Text
            };


            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App._books_db))
            {
                conn.CreateTable<Book>();
                var nRows = conn.Insert(book);
                if(nRows > 0)
                {
                    DisplayAlert("success", nRows.ToString(), "Great!");
                }
                else
                {
                    DisplayAlert("failure", "failed saved", "bad!");
                }
                
            }

            //DisplayAlert("success", "successfully saved", "Great!");
        }
    }
}