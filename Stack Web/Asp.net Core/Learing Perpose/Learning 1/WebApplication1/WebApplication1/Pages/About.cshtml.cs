using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebAppUN.Pages
{
    public class AboutModel : PageModel
    {

        private List<Book> ListOfBooks;
        private readonly IConfiguration configuration;

        public AboutModel(IConfiguration configuration)
        {
            ListOfBooks = new List<Book>();
            ListOfBooks.Add(new Book { Id = 1, Title = "learn c sharp", author = "amar", price = 10 });
            ListOfBooks.Add(new Book { Id = 2, Title = "learn java", author = "amar", price = 20 });
            ListOfBooks.Add(new Book { Id = 3, Title = "learn c++", author = "amar", price = 100 });
            
            //inject
            this.configuration = configuration;
        }

        public List<Book> GetBook()
        {
            return ListOfBooks;
        }

        public string GetPageTitle()
        {
            return configuration["AboutPage"];
        }

        public string GetTitle()
        {
            return Properties.Resources.TitleWoW;
        }

        public void OnGet()
        {

        }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string author { get; set; }
        public int price { get; set; }
    }
}
