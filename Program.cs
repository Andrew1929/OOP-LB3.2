using System;

namespace OOP_LB_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("author", "title", "content");
            Author author = new Author("author", "", "");
            Title title = new Title("", "title", "");
            Content content = new Content("", "", "content");
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
