using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._2
{
    class Author : Book
    {
        private string author;
        public Author(string content, string author, string title) : base(content, author, title)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
