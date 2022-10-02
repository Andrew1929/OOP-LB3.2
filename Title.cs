using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._2
{
    class Title:Book
    {
        private string title;
        public Title(string content, string author, string title) : base(content, author, title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}
