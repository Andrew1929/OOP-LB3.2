using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._2
{
    class Content : Book
    {
        private string content;
        public Content(string content, string author, string title) : base(content, author, title)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
          
        }
    }
}
