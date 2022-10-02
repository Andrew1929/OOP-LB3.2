using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._2
{
    class Book 
    {
        protected string content;
        protected string author;
        protected string title;

       public Book(string content, string author, string title)
       {
            this.content = content;
            this.author = author;
            this.title = title;
       }
  
    }
}
