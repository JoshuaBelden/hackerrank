using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerrank
{
    public abstract class Book
    {
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string title { get; set; }
        public string author { get; set; }

        public abstract void display();
    }

    class MyBook : Book
    {
        public int price { get; set; }

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }
}
