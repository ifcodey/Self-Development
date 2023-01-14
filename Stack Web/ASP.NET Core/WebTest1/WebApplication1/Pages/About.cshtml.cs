using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration; 

namespace WebApplication1.Pages
{
    public class AboutModel : PageModel
    {
        private List<Book> books;

        public string Title;
        private readonly IConfiguration configuration;

        public AboutModel(IConfiguration configuration)
        {
            Title = "About Page";
            books = new List<Book>
            {
                new Book { Id=1,Title="C#",Author="Ahmed",price=24,MyProperty=1},
                new Book { Id=2,Title="java",Author="Ahmed",price=28,MyProperty=2},
                new Book { Id=3,Title="DataStructure",Author="Ahmed",price=35,MyProperty=2},
            };
            //Injection.
            this.configuration = configuration;
            //set
/*            configuration["AboutPageTitle"] = "About page from model";
*/        }
        public void OnGet()
        {

        }

        public string GetTitle()
        {
            /*return Title;*/
            return Properties.Resources.AboutPageTitle;
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public string GetPageTitle()
        {
            //get
            return configuration["AboutPageTitle"];
        }

    }

    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int MyProperty { get; set; }
        public int price { get; set; }
    }


}
