using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBooks
{
    public class Book
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Auther { get; set; }

    }
}
