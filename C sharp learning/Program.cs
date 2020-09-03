using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    
    struct Book
    {
        public string title;
        public string name;
        public string author;
    };

    class MainClass
    {   
        public static void Main(string[] args)
        {
            Book book;
            book.name = "Pushkin";
            book.title = "Lolec";
            book.author = "aaa";
            Console.ReadLine();
        }

    }
}