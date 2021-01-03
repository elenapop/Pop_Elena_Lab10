using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Pop_Elena_Lab10.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Description { get; set; }

        public List<ListProduct> ListProducts { get; set; }

    }
}
